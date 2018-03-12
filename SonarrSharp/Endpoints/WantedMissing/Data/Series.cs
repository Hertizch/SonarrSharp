using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.WantedMissing.Data
{
    public partial class Series
    {
        [J("tvdbId")] public long TvdbId { get; set; }
        [J("tvRageId")] public long TvRageId { get; set; }
        [J("imdbId")] public string ImdbId { get; set; }
        [J("title")] public string Title { get; set; }
        [J("cleanTitle")] public string CleanTitle { get; set; }
        [J("status")] public string Status { get; set; }
        [J("overview")] public string Overview { get; set; }
        [J("airTime")] public string AirTime { get; set; }
        [J("monitored")] public bool Monitored { get; set; }
        [J("qualityProfileId")] public long QualityProfileId { get; set; }
        [J("seasonFolder")] public bool SeasonFolder { get; set; }
        [J("lastInfoSync")] public DateTimeOffset LastInfoSync { get; set; }
        [J("runtime")] public long Runtime { get; set; }
        [J("images")] public Image[] Images { get; set; }
        [J("seriesType")] public string SeriesType { get; set; }
        [J("network")] public string Network { get; set; }
        [J("useSceneNumbering")] public bool UseSceneNumbering { get; set; }
        [J("titleSlug")] public string TitleSlug { get; set; }
        [J("path")] public string Path { get; set; }
        [J("year")] public long Year { get; set; }
        [J("firstAired")] public DateTimeOffset FirstAired { get; set; }
        [J("qualityProfile")] public QualityProfile QualityProfile { get; set; }
        [J("seasons")] public Season[] Seasons { get; set; }
        [J("id")] public long Id { get; set; }
    }
}
