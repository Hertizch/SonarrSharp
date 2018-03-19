using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Queue.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Series
    {
        /// <summary>
        /// 
        /// </summary>
        [J("title")] public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("sortTitle")] public string SortTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("seasonCount")] public long SeasonCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("status")] public string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("overview")] public string Overview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("network")] public string Network { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("airTime")] public string AirTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("images")] public Image[] Images { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("seasons")] public Season[] Seasons { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("year")] public long Year { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("path")] public string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("profileId")] public long ProfileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("seasonFolder")] public bool SeasonFolder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("monitored")] public bool Monitored { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("useSceneNumbering")] public bool UseSceneNumbering { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("runtime")] public long Runtime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("tvdbId")] public long TvdbId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("tvRageId")] public long TvRageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("tvMazeId")] public long TvMazeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("firstAired")] public DateTimeOffset FirstAired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("lastInfoSync")] public DateTimeOffset LastInfoSync { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("seriesType")] public string SeriesType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("cleanTitle")] public string CleanTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("imdbId")] public string ImdbId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("titleSlug")] public string TitleSlug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("certification")] public string Certification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("genres")] public string[] Genres { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("tags")] public object[] Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("added")] public DateTimeOffset Added { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("ratings")] public Ratings Ratings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("qualityProfileId")] public long QualityProfileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("id")] public long Id { get; set; }
    }
}
