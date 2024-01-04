using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace OneNoteExporter
{
    public static class StringUtility
    {
        public static string GenerateCharacters(int length, Random random)
        {
            const string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var result = new StringBuilder(length);
            for (var i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }
            return result.ToString();
        }


        public static string GetSafeFilename(this string str)
        {
            var retval = string.Join("_", str.Split(Path.GetInvalidFileNameChars()));
               // .Replace(" ", "_");

            return retval;

        }
        public static string RemoveOneNoteHeader(string pageTxt)
        {
            var pageTxtModified = Regex.Replace(pageTxt, @"^.+(\n|\r|\r\n){1,2}.+(\n|\r|\r\n){1,2}\d{2}:\d{2}\s+", "");

            return pageTxtModified;
        }

        public static string RemoveUTF8NonBreakingSpace(string pageTxt)
        {
            // Max 2 consecutive linebreaks
            var pageTxtModified = Regex.Replace(pageTxt, @"(\xa0|\xc2|\xc2\xa0)", string.Empty);

            return pageTxtModified;
        }

        public static string RemoveHtmlCommentBlocks(string pageTxt)
        {
            // Pandoc produce <!-- --> tags
            var pageTxtModified = Regex.Replace(pageTxt, @"(\n|\r|\r\n)( )*\<!--( )*--\>( )*", "");

            return pageTxtModified;
        }


        public static string DeduplicateLinebreaks(string pageTxt)
        {
            // PanDoc seems to produce 2 linebreaks characters for each linebreak in original DocX file
            // Replace all pair of linebreak by a single linebreak
            var pageTxtModified = Regex.Replace(pageTxt, @"(\n{2}|\r{2}|(\r\n){2})", Environment.NewLine);

            return pageTxtModified;
        }

        public static string MaxTwoLineBreaksInARow(string pageTxt)
        {
            // Max 2 consecutive linebreaks
            var pageTxtModified = Regex.Replace(pageTxt, @"((\n[ \t]*\n+)|(\r[ \t]*\r+)|(\r\n[ \t]*(\r\n)+))",
                Environment.NewLine + Environment.NewLine, RegexOptions.Multiline);

            return pageTxtModified;
        }

        public static string RemoveQuotationBlocks(string pageTxt)
        {
            string regex = @"(\n|\r|\r\n)>(\n|\r|\r\n)";
            var pageTxtModified = Regex.Replace(pageTxt, regex, delegate (Match match)
            {
                return Environment.NewLine;
            });

            string regex2 = @"(\n|\r|\r\n)>[ ]?";
            pageTxtModified = Regex.Replace(pageTxtModified, regex2, delegate (Match match)
            {
                return Environment.NewLine;
            });


            return pageTxtModified;
        }

        /// <summary>
        /// Replace PanDoc html tags <span class="mark">text</span> by ==text== 
        /// </summary>
        /// <param name="pageTxt"></param>
        /// <returns></returns>
        public static string InsertMdHighlight(string pageTxt)
        {
            // match and replace each span block of a row
            string regex = @"\<span class=\""mark\""\>(?<text>((?!\</span\>).)*)\</span\>"; // https://stackoverflow.com/questions/406230/regular-expression-to-match-a-line-that-doesnt-contain-a-word
            var pageTxtModified = Regex.Replace(pageTxt, regex, delegate (Match match)
            {
                return "==" + (match.Groups["text"]?.Value ?? "") + "==";
            });

            return pageTxtModified;
        }

    }
}
