using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.History.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Data
    {
        /// <summary>
        /// Gets or sets the dropped path.
        /// </summary>
        /// <value>
        /// The dropped path.
        /// </value>
        [J("droppedPath")] public string DroppedPath { get; set; }

        /// <summary>
        /// Gets or sets the imported path.
        /// </summary>
        /// <value>
        /// The imported path.
        /// </value>
        [J("importedPath")] public string ImportedPath { get; set; }

        /// <summary>
        /// Gets or sets the download client.
        /// </summary>
        /// <value>
        /// The download client.
        /// </value>
        [J("downloadClient")] public string DownloadClient { get; set; }

        /// <summary>
        /// Gets or sets the reason.
        /// </summary>
        /// <value>
        /// The reason.
        /// </value>
        [J("reason")] public string Reason { get; set; }
    }
}
