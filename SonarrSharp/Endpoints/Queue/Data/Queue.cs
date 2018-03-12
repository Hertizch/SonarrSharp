using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Queue.Data
{
    public partial class Queue
    {
        [J("series")] public Series Series { get; set; }
        [J("episode")] public Episode Episode { get; set; }
        [J("quality")] public QueueQuality Quality { get; set; }
        [J("size")] public long Size { get; set; }
        [J("title")] public string Title { get; set; }
        [J("sizeleft")] public long Sizeleft { get; set; }
        [J("timeleft")] public DateTimeOffset Timeleft { get; set; }
        [J("estimatedCompletionTime")] public DateTimeOffset EstimatedCompletionTime { get; set; }
        [J("status")] public string Status { get; set; }
        [J("trackedDownloadStatus")] public string TrackedDownloadStatus { get; set; }
        [J("statusMessages")] public object[] StatusMessages { get; set; }
        [J("downloadId")] public string DownloadId { get; set; }
        [J("protocol")] public string Protocol { get; set; }
        [J("id")] public long Id { get; set; }
    }
}
