using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Queue.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Queue
    {
        /// <summary>
        /// 
        /// </summary>
        [J("series")] public Series Series { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("episode")] public Episode Episode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("quality")] public QueueQuality Quality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("size")] public long Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("title")] public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("sizeleft")] public long Sizeleft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("timeleft")] public DateTimeOffset Timeleft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("estimatedCompletionTime")] public DateTimeOffset EstimatedCompletionTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("status")] public string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("trackedDownloadStatus")] public string TrackedDownloadStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("statusMessages")] public object[] StatusMessages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("downloadId")] public string DownloadId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("protocol")] public string Protocol { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("id")] public long Id { get; set; }
    }
}
