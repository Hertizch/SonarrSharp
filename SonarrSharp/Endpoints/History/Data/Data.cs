using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.History.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Data
    {
        /// <summary>
        /// 
        /// </summary>
        [J("droppedPath")] public string DroppedPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("importedPath")] public string ImportedPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("downloadClient")] public string DownloadClient { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("reason")] public string Reason { get; set; }
    }
}
