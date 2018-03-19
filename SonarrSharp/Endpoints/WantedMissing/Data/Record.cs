using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.WantedMissing.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Record
    {
        /// <summary>
        /// 
        /// </summary>
        [J("seriesId")] public long SeriesId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("episodeFileId")] public long EpisodeFileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("seasonNumber")] public long SeasonNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("episodeNumber")] public long EpisodeNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("title")] public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("airDate")] public DateTimeOffset AirDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("airDateUtc")] public DateTimeOffset AirDateUtc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("overview")] public string Overview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("hasFile")] public bool HasFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("monitored")] public bool Monitored { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("sceneEpisodeNumber")] public long SceneEpisodeNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("sceneSeasonNumber")] public long SceneSeasonNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("tvDbEpisodeId")] public long TvDbEpisodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("absoluteEpisodeNumber")] public long AbsoluteEpisodeNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("series")] public Series Series { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("downloading")] public bool Downloading { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("id")] public long Id { get; set; }
    }
}
