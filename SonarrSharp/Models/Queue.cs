using SonarrSharp.Enum;
using System;
using System.Collections.Generic;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Queue
    {
        /// <summary>
        /// Gets or sets the series.
        /// </summary>
        /// <value>
        /// The series.
        /// </value>
        [J("series")] public Series Series { get; set; }

        /// <summary>
        /// Gets or sets the episode.
        /// </summary>
        /// <value>
        /// The episode.
        /// </value>
        [J("episode")] public Episode Episode { get; set; }

        /// <summary>
        /// Gets or sets the quality.
        /// </summary>
        /// <value>
        /// The quality.
        /// </value>
        [J("quality")] public QueueQuality Quality { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        [J("size")] public long Size { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [J("title")] public string Title { get; set; }

        /// <summary>
        /// Gets or sets the sizeleft.
        /// </summary>
        /// <value>
        /// The sizeleft.
        /// </value>
        [J("sizeleft")] public long Sizeleft { get; set; }

        /// <summary>
        /// Gets or sets the timeleft.
        /// </summary>
        /// <value>
        /// The timeleft.
        /// </value>
        [J("timeleft")] public DateTimeOffset Timeleft { get; set; }

        /// <summary>
        /// Gets or sets the estimated completion time.
        /// </summary>
        /// <value>
        /// The estimated completion time.
        /// </value>
        [J("estimatedCompletionTime")] public DateTimeOffset EstimatedCompletionTime { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        [J("status")] public string Status { get; set; }

        /// <summary>
        /// Gets or sets the tracked download status.
        /// </summary>
        /// <value>
        /// The tracked download status.
        /// </value>
        [J("trackedDownloadStatus")] public string TrackedDownloadStatus { get; set; }

        /// <summary>
        /// Gets or sets the status messages.
        /// </summary>
        /// <value>
        /// The status messages.
        /// </value>
        [J("statusMessages")] public IList<object> StatusMessages { get; set; }

        /// <summary>
        /// Gets or sets the download identifier.
        /// </summary>
        /// <value>
        /// The download identifier.
        /// </value>
        [J("downloadId")] public string DownloadId { get; set; }

        /// <summary>
        /// Gets or sets the protocol.
        /// </summary>
        /// <value>
        /// The protocol.
        /// </value>
        [J("protocol")] public Protocol Protocol { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public long Id { get; set; }
    }
}
