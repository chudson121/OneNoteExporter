using System.Collections.Generic;
using Newtonsoft.Json;

namespace OneNoteExporter.OneNoteModels
{


    public class PageInfo : OneNoteNode
    {
        [JsonProperty(Order = 1)]
        public List<PageInfo> Pages { get; } = new List<PageInfo>();

        public string SectionName { get; set; }
        

    }
}
