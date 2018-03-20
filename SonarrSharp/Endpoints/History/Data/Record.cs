using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.History.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Record
    {
        /// <summary>
        /// Gets or sets the episode identifier.
        /// </summary>
        /// <value>
        /// The episode identifier.
        /// </value>
        [J("episodeId")] public long EpisodeId { get; set; }

        /// <summary>
        /// Gets or sets the series identifier.
        /// </summary>
        /// <value>
        /// The series identifier.
        /// </value>
        [J("seriesId")] public long SeriesId { get; set; }

        /// <summary>
        /// Gets or sets the source title.
        /// </summary>
        /// <value>
        /// The source title.
        /// </value>
        [J("sourceTitle")] public string SourceTitle { get; set; }

        /// <summary>
        /// Gets or sets the quality.
        /// </summary>
        /// <value>
        /// The quality.
        /// </value>
        [J("quality")] public RecordQuality Quality { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [quality cutoff not met].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [quality cutoff not met]; otherwise, <c>false</c>.
        /// </value>
        [J("qualityCutoffNotMet")] public bool QualityCutoffNotMet { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        [J("date")] public DateTimeOffset Date { get; set; }

        /// <summary>
        /// Gets or sets the download identifier.
        /// </summary>
        /// <value>
        /// The download identifier.
        /// </value>
        [J("downloadId")] public string DownloadId { get; set; }

        /// <summary>
        /// Gets or sets the type of the event.
        /// </summary>
        /// <value>
        /// The type of the event.
        /// </value>
        [J("eventType")] public string EventType { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        [J("data")] public Data Data { get; set; }

        /// <summary>
        /// Gets or sets the episode.
        /// </summary>
        /// <value>
        /// The episode.
        /// </value>
        [J("episode")] public Episode Episode { get; set; }

        /// <summary>
        /// Gets or sets the series.
        /// </summary>
        /// <value>
        /// The series.
        /// </value>
        [J("series")] public Series Series { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public long Id { get; set; }
    }
}
