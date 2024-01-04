using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Microsoft.Office.Interop.OneNote;
using OneNoteExporter.OneNoteModels;
using OpenTelemetry.Trace;
using PageInfo = OneNoteExporter.OneNoteModels.PageInfo;

namespace OneNoteExporter
{
    public static class OneNoteExtensions
    {
        public static string ToAscii(this string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            var asciiChars = value.Where(ch => Encoding.UTF8.GetByteCount(new[] { ch }) == 1).ToArray();
            return new string(asciiChars);
        }

        public static string GetObjectId(this Application oneNoteApp, string parentId, HierarchyScope scope, string objectName)
        {
            oneNoteApp.GetHierarchy(parentId, scope, out var xml);

            var doc = XDocument.Parse(xml);
            if (doc.Root == null) return string.Empty;

            var ns = doc.Root.Name.Namespace;
            var nodeName = "";

            switch (scope)
            {
                case (HierarchyScope.hsNotebooks): nodeName = "Notebook"; break;
                case (HierarchyScope.hsSections): nodeName = "Section"; break;
                case (HierarchyScope.hsPages): nodeName = "Page"; break;
                case HierarchyScope.hsSelf:
                    break;
                case HierarchyScope.hsChildren:
                    break;
                default:
                    return null;
            }

            var node = doc.Descendants(ns + nodeName).FirstOrDefault(n => n.Attribute("name")?.Value == objectName);

            return node != null ? node.Attribute("ID")?.Value : string.Empty;
        }

        public static NotebookInfo[] GetNotebooks(this Application oneNoteApp)
        {
            oneNoteApp.GetHierarchy(null, HierarchyScope.hsNotebooks, out string xml);
            var doc = XDocument.Parse(xml);
            if (doc.Root == null)
            {
                return Array.Empty<NotebookInfo>();
            }

            var ns = doc.Root.Name.Namespace;
            var elements = doc.Descendants(ns + "Notebook").ToArray();

            var notebookInfos = new List<NotebookInfo>(elements.Length);

            foreach (var element in elements)
            {
                var notebook =
                    new NotebookInfo()
                    {
                        Id = element.Attribute("ID")?.Value,
                        Title = element.Attribute("name")?.Value.ToAscii(),
                        Path = element.Attribute("path")?.Value,
                        Type = element.Name.LocalName
                        
                    };

                oneNoteApp.GetHyperlinkToObject(notebook.Id, "", out string url);

                notebook.Sections = oneNoteApp.GetSections(notebook.Id);
                notebook.Url = url;

                notebookInfos.Add(notebook);
            }

            return notebookInfos.ToArray();
        }

        public static SectionBase[] GetSections(this Application oneNoteApp, string notebookId)
        {
            oneNoteApp.GetHierarchy(notebookId, HierarchyScope.hsSections, out var xml);

            var doc = XDocument.Parse(xml);

            var notebook = doc.Elements().First();

            return oneNoteApp.GetSections(notebook);
        }

        private static SectionBase[] GetSections(this Application oneNoteApp, XContainer root)
        {
            var elements =
                root.Elements()
                    .Where(element =>
                            element.Attribute("isRecycleBin") == null &&
                            element.Attribute("isDeletedPages") == null
                    )
                    .ToArray();

            var sections = new List<SectionBase>(elements.Length);

            foreach (var element in elements)
            {
                var sectionId = element.Attribute("ID")?.Value;
                SectionBase section = null;

                switch (element.Name.LocalName)
                {
                    case "SectionGroup":
                        section = new SectionGroupInfo()
                        {
                            Sections = oneNoteApp.GetSections(element)
                        };
                        break;
                    case "Section":
                        {
                            var sectionInfo = new SectionInfo();
                            section = sectionInfo;
                            break;
                        }
                }

                if (section == null) continue;

                oneNoteApp.GetHyperlinkToObject(sectionId, "", out var url);

                section.Id = sectionId;
                section.Title = element.Attribute("name")?.Value.ToAscii();
                section.Path = element.Attribute("path")?.Value;
                section.Type = element.Name.LocalName;
                section.Url = url;

                sections.Add(section);
            }

            return sections.ToArray();
        }

        public static List<PageInfo> GetPages(this Application oneNoteApp, SectionBase section)
        {
            var retval = new List<PageInfo>();

            oneNoteApp.GetHierarchy(section.Id, HierarchyScope.hsPages, out var xml);
            var doc = XDocument.Parse(xml);

            if (doc.Root == null)
            {
                return retval;
            }

            var ns = doc.Root.Name.Namespace;
            var elements =
                doc.Descendants(ns + "Page")
                    .Where(
                        element =>
                            element.Attribute("isRecycleBin") == null &&
                            element.Attribute("isDeletedPages") == null
                    )
                    .ToArray();


            foreach (var element in elements)
            {
                var pageId = element.Attribute("ID")?.Value;

                oneNoteApp.GetHyperlinkToObject(pageId, "", out var url);

                var page =
                    new PageInfo()
                    {
                        Id = pageId,
                        Title = element.Attribute("name")?.Value.ToAscii(),
                        Type = element.Name.LocalName,
                        Url = url,
                        SectionName = section.Title
                    };


                retval.Add(page);
            }

            return retval;
        }

        public static List<OneNoteModels.NotebookInfo> GetNotebookInfos(OneNoteModels.NotebookInfo[] notebookCollecction, string filterContentName)
        {
            var returnedList = new List<OneNoteModels.NotebookInfo>();

            if (string.IsNullOrEmpty(filterContentName)) //process all
            {
                return returnedList;
            }

            foreach (var nb in from nb in notebookCollecction
                               where string.Equals(nb.Title, filterContentName, StringComparison.CurrentCultureIgnoreCase)
                               select nb)
            {
                returnedList.Add(nb);
                break;
            }

            return returnedList;
        }

        public static List<OneNoteModels.SectionBase> GetFilteredSections(List<OneNoteModels.NotebookInfo> notebookCollecction, string sectionName)
        {
            var returnedSections = new List<OneNoteModels.SectionBase>();

            foreach (var nb in notebookCollecction)
            {

                //empty filter add all sections from notebook
                if (string.IsNullOrEmpty(sectionName)) //process all sections
                {
                    return returnedSections = new List<OneNoteModels.SectionBase>(nb.Sections);
                }

                //Filter
                var sectionBaseMatchingFilter = nb.Sections.FirstOrDefault(
                        name => name.Title.ToLowerInvariant() == sectionName.ToLowerInvariant());

                returnedSections.Add(sectionBaseMatchingFilter);

            }

            return returnedSections;

        }

        public static List<PageInfo> GetPageInfoForSections(this Application oneNoteApp, List<OneNoteModels.SectionBase> FilteredSections)
        {

            var pageInfoList = new List<PageInfo>();

            //using var span = Tracer.StartActiveSpan("Getting pages");


            foreach (var section in FilteredSections)
            {
                //span.SetAttribute("app.PageInfo.message", $"Getting pages for Section: {section.Title}");
                //Log.Information($"Getting pages for Section: {section.Title}");
                //SectionCounter.Add(1);
                pageInfoList.AddRange(oneNoteApp.GetPages(section));

                //FilesProcessedCount += pageInfoList.Count;

            }

            //span.End(new DateTimeOffset());

            return pageInfoList;


        }


    }
}

