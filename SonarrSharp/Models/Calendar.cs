using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Calendar
    {
        /// <summary>
        /// Gets or sets the series identifier.
        /// </summary>
        /// <value>
        /// The series identifier.
        /// </value>
        [J("seriesId")] public int SeriesId { get; set; }

        /// <summary>
        /// Gets or sets the episode file identifier.
        /// </summary>
        /// <value>
        /// The episode file identifier.
        /// </value>
        [J("episodeFileId")] public int EpisodeFileId { get; set; }

        /// <summary>
        /// Gets or sets the season number.
        /// </summary>
        /// <value>
        /// The season number.
        /// </value>
        [J("seasonNumber")] public int SeasonNumber { get; set; }

        /// <summary>
        /// Gets or sets the episode number.
        /// </summary>
        /// <value>
        /// The episode number.
        /// </value>
        [J("episodeNumber")] public int EpisodeNumber { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [J("title")] public string Title { get; set; }

        /// <summary>
        /// Gets or sets the air date.
        /// </summary>
        /// <value>
        /// The air date.
        /// </value>
        [J("airDate")] public DateTimeOffset AirDate { get; set; }

        /// <summary>
        /// Gets or sets the air date UTC.
        /// </summary>
        /// <value>
        /// The air date UTC.
        /// </value>
        [J("airDateUtc")] public DateTimeOffset AirDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the overview.
        /// </summary>
        /// <value>
        /// The overview.
        /// </value>
        [J("overview")] public string Overview { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has file.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has file; otherwise, <c>false</c>.
        /// </value>
        [J("hasFile")] public bool HasFile { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Calendar"/> is monitored.
        /// </summary>
        /// <value>
        ///   <c>true</c> if monitored; otherwise, <c>false</c>.
        /// </value>
        [J("monitored")] public bool Monitored { get; set; }

        /// <summary>
        /// Gets or sets the scene episode number.
        /// </summary>
        /// <value>
        /// The scene episode number.
        /// </value>
        [J("sceneEpisodeNumber")] public int SceneEpisodeNumber { get; set; }

        /// <summary>
        /// Gets or sets the scene season number.
        /// </summary>
        /// <value>
        /// The scene season number.
        /// </value>
        [J("sceneSeasonNumber")] public int SceneSeasonNumber { get; set; }

        /// <summary>
        /// Gets or sets the tv database episode identifier.
        /// </summary>
        /// <value>
        /// The tv database episode identifier.
        /// </value>
        [J("tvDbEpisodeId")] public int TvDbEpisodeId { get; set; }

        /// <summary>
        /// Gets or sets the series.
        /// </summary>
        /// <value>
        /// The series.
        /// </value>
        [J("series")] public Series Series { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Calendar"/> is downloading.
        /// </summary>
        /// <value>
        ///   <c>true</c> if downloading; otherwise, <c>false</c>.
        /// </value>
        [J("downloading")] public bool Downloading { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public int Id { get; set; }
    }
}
