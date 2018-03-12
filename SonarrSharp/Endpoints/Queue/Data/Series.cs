using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Queue.Data
{
    public partial class Series
    {
        [J("title")] public string Title { get; set; }
        [J("sortTitle")] public string SortTitle { get; set; }
        [J("seasonCount")] public long SeasonCount { get; set; }
        [J("status")] public string Status { get; set; }
        [J("overview")] public string Overview { get; set; }
        [J("network")] public string Network { get; set; }
        [J("airTime")] public string AirTime { get; set; }
        [J("images")] public Image[] Images { get; set; }
        [J("seasons")] public Season[] Seasons { get; set; }
        [J("year")] public long Year { get; set; }
        [J("path")] public string Path { get; set; }
        [J("profileId")] public long ProfileId { get; set; }
        [J("seasonFolder")] public bool SeasonFolder { get; set; }
        [J("monitored")] public bool Monitored { get; set; }
        [J("useSceneNumbering")] public bool UseSceneNumbering { get; set; }
        [J("runtime")] public long Runtime { get; set; }
        [J("tvdbId")] public long TvdbId { get; set; }
        [J("tvRageId")] public long TvRageId { get; set; }
        [J("tvMazeId")] public long TvMazeId { get; set; }
        [J("firstAired")] public DateTimeOffset FirstAired { get; set; }
        [J("lastInfoSync")] public DateTimeOffset LastInfoSync { get; set; }
        [J("seriesType")] public string SeriesType { get; set; }
        [J("cleanTitle")] public string CleanTitle { get; set; }
        [J("imdbId")] public string ImdbId { get; set; }
        [J("titleSlug")] public string TitleSlug { get; set; }
        [J("certification")] public string Certification { get; set; }
        [J("genres")] public string[] Genres { get; set; }
        [J("tags")] public object[] Tags { get; set; }
        [J("added")] public DateTimeOffset Added { get; set; }
        [J("ratings")] public Ratings Ratings { get; set; }
        [J("qualityProfileId")] public long QualityProfileId { get; set; }
        [J("id")] public long Id { get; set; }
    }
}
