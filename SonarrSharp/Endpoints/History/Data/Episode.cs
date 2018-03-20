using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.History.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Episode
    {
        /// <summary>
        /// Gets or sets the series identifier.
        /// </summary>
        /// <value>
        /// The series identifier.
        /// </value>
        [J("seriesId")] public long SeriesId { get; set; }

        /// <summary>
        /// Gets or sets the episode file identifier.
        /// </summary>
        /// <value>
        /// The episode file identifier.
        /// </value>
        [J("episodeFileId")] public long EpisodeFileId { get; set; }

        /// <summary>
        /// Gets or sets the season number.
        /// </summary>
        /// <value>
        /// The season number.
        /// </value>
        [J("seasonNumber")] public long SeasonNumber { get; set; }

        /// <summary>
        /// Gets or sets the episode number.
        /// </summary>
        /// <value>
        /// The episode number.
        /// </value>
        [J("episodeNumber")] public long EpisodeNumber { get; set; }

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
        /// Gets or sets a value indicating whether this <see cref="Episode"/> is monitored.
        /// </summary>
        /// <value>
        ///   <c>true</c> if monitored; otherwise, <c>false</c>.
        /// </value>
        [J("monitored")] public bool Monitored { get; set; }

        /// <summary>
        /// Gets or sets the absolute episode number.
        /// </summary>
        /// <value>
        /// The absolute episode number.
        /// </value>
        [J("absoluteEpisodeNumber")] public long AbsoluteEpisodeNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [unverified scene numbering].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [unverified scene numbering]; otherwise, <c>false</c>.
        /// </value>
        [J("unverifiedSceneNumbering")] public bool UnverifiedSceneNumbering { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public long Id { get; set; }
    }
}
