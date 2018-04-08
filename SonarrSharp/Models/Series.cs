using SonarrSharp.Enum;
using System;
using System.Collections.Generic;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Series
    {
        /// <summary>
        /// Gets or sets the TVDB identifier.
        /// </summary>
        /// <value>
        /// The TVDB identifier.
        /// </value>
        [J("tvdbId")] public long TvdbId { get; set; }

        /// <summary>
        /// Gets or sets the tv rage identifier.
        /// </summary>
        /// <value>
        /// The tv rage identifier.
        /// </value>
        [J("tvRageId")] public long TvRageId { get; set; }

        /// <summary>
        /// Gets or sets the imdb identifier.
        /// </summary>
        /// <value>
        /// The imdb identifier.
        /// </value>
        [J("imdbId")] public string ImdbId { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [J("title")] public string Title { get; set; }

        /// <summary>
        /// Gets or sets the clean title.
        /// </summary>
        /// <value>
        /// The clean title.
        /// </value>
        [J("cleanTitle")] public string CleanTitle { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        [J("status")] public Status Status { get; set; }

        /// <summary>
        /// Gets or sets the overview.
        /// </summary>
        /// <value>
        /// The overview.
        /// </value>
        [J("overview")] public string Overview { get; set; }

        /// <summary>
        /// Gets or sets the air time.
        /// </summary>
        /// <value>
        /// The air time.
        /// </value>
        [J("airTime")] public string AirTime { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Series"/> is monitored.
        /// </summary>
        /// <value>
        ///   <c>true</c> if monitored; otherwise, <c>false</c>.
        /// </value>
        [J("monitored")] public bool Monitored { get; set; }

        /// <summary>
        /// Gets or sets the quality profile identifier.
        /// </summary>
        /// <value>
        /// The quality profile identifier.
        /// </value>
        [J("qualityProfileId")] public long QualityProfileId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [season folder].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [season folder]; otherwise, <c>false</c>.
        /// </value>
        [J("seasonFolder")] public bool SeasonFolder { get; set; }

        /// <summary>
        /// Gets or sets the last information synchronize.
        /// </summary>
        /// <value>
        /// The last information synchronize.
        /// </value>
        [J("lastInfoSync")] public DateTimeOffset LastInfoSync { get; set; }

        /// <summary>
        /// Gets or sets the runtime.
        /// </summary>
        /// <value>
        /// The runtime.
        /// </value>
        [J("runtime")] public long Runtime { get; set; }

        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        /// <value>
        /// The images.
        /// </value>
        [J("images")] public IList<Image> Images { get; set; }

        /// <summary>
        /// Gets or sets the type of the series.
        /// </summary>
        /// <value>
        /// The type of the series.
        /// </value>
        [J("seriesType")] public SeriesType SeriesType { get; set; }

        /// <summary>
        /// Gets or sets the network.
        /// </summary>
        /// <value>
        /// The network.
        /// </value>
        [J("network")] public string Network { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [use scene numbering].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [use scene numbering]; otherwise, <c>false</c>.
        /// </value>
        [J("useSceneNumbering")] public bool UseSceneNumbering { get; set; }

        /// <summary>
        /// Gets or sets the title slug.
        /// </summary>
        /// <value>
        /// The title slug.
        /// </value>
        [J("titleSlug")] public string TitleSlug { get; set; }

        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>
        /// The path.
        /// </value>
        [J("path")] public string Path { get; set; }

        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        /// <value>
        /// The year.
        /// </value>
        [J("year")] public long Year { get; set; }

        /// <summary>
        /// Gets or sets the first aired.
        /// </summary>
        /// <value>
        /// The first aired.
        /// </value>
        [J("firstAired")] public DateTimeOffset FirstAired { get; set; }

        /// <summary>
        /// Gets or sets the quality profile.
        /// </summary>
        /// <value>
        /// The quality profile.
        /// </value>
        [J("qualityProfile")] public QualityProfile QualityProfile { get; set; }

        /// <summary>
        /// Gets or sets the seasons.
        /// </summary>
        /// <value>
        /// The seasons.
        /// </value>
        [J("seasons")] public IList<Season> Seasons { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public long Id { get; set; }
    }
}
