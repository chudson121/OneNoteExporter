using System.Collections.Generic;
using Newtonsoft.Json;

namespace OneNoteExporter.OneNoteModels
{
    public class SectionBase : OneNoteNode
    {
        public string Path { get; set; }
    }

    public class SectionGroupInfo : SectionBase
    {
        [JsonProperty(Order = 1)]
        public SectionBase[] Sections { get; set; }
    }

    public class SectionInfo : SectionBase
    {
        [JsonProperty(Order = 1)]
        public List<PageInfo> Pages { get; } = new List<PageInfo>();
    }
}