using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.History.Data
{
    public partial class Data
    {
        [J("droppedPath")] public string DroppedPath { get; set; }
        [J("importedPath")] public string ImportedPath { get; set; }
        [J("downloadClient")] public string DownloadClient { get; set; }
        [J("reason")] public string Reason { get; set; }
    }
}
