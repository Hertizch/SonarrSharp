using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.History.Data
{
    public partial class Record
    {
        [J("episodeId")] public long EpisodeId { get; set; }
        [J("seriesId")] public long SeriesId { get; set; }
        [J("sourceTitle")] public string SourceTitle { get; set; }
        [J("quality")] public RecordQuality Quality { get; set; }
        [J("qualityCutoffNotMet")] public bool QualityCutoffNotMet { get; set; }
        [J("date")] public DateTimeOffset Date { get; set; }
        [J("downloadId")] public string DownloadId { get; set; }
        [J("eventType")] public string EventType { get; set; }
        [J("data")] public Data Data { get; set; }
        [J("episode")] public Episode Episode { get; set; }
        [J("series")] public Series Series { get; set; }
        [J("id")] public long Id { get; set; }
    }
}
