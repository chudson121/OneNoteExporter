using Newtonsoft.Json;

namespace OneNoteExporter.OneNoteModels
{
    public class NotebookInfo : OneNoteNode
    {
        public string Path { get; set; }

        [JsonProperty(Order = 1)]
        public SectionBase[] Sections { get; set; }

  


    }
}