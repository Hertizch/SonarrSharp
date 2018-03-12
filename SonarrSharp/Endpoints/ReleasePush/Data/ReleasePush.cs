using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.ReleasePush.Data
{
    public partial class ReleasePush
    {
        [J("guid")] public string Guid { get; set; }
        [J("quality")] public ReleasePushQuality Quality { get; set; }
        [J("age")] public long Age { get; set; }
        [J("size")] public long Size { get; set; }
        [J("indexer")] public string Indexer { get; set; }
        [J("releaseGroup")] public string ReleaseGroup { get; set; }
        [J("title")] public string Title { get; set; }
        [J("fullSeason")] public bool FullSeason { get; set; }
        [J("sceneSource")] public bool SceneSource { get; set; }
        [J("seasonNumber")] public long SeasonNumber { get; set; }
        [J("language")] public string Language { get; set; }
        [J("seriesTitle")] public string SeriesTitle { get; set; }
        [J("episodeNumbers")] public long[] EpisodeNumbers { get; set; }
        [J("approved")] public bool Approved { get; set; }
        [J("tvRageId")] public long TvRageId { get; set; }
        [J("rejections")] public string[] Rejections { get; set; }
        [J("publishDate")] public DateTimeOffset PublishDate { get; set; }
        [J("downloadUrl")] public string DownloadUrl { get; set; }
        [J("downloadAllowed")] public bool DownloadAllowed { get; set; }
    }
}
