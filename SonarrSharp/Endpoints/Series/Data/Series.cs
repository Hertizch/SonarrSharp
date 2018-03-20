using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Series.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Series
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [J("title")] public string Title { get; set; }

        /// <summary>
        /// Gets or sets the alternate titles.
        /// </summary>
        /// <value>
        /// The alternate titles.
        /// </value>
        [J("alternateTitles")] public AlternateTitle[] AlternateTitles { get; set; }

        /// <summary>
        /// Gets or sets the sort title.
        /// </summary>
        /// <value>
        /// The sort title.
        /// </value>
        [J("sortTitle")] public string SortTitle { get; set; }

        /// <summary>
        /// Gets or sets the season count.
        /// </summary>
        /// <value>
        /// The season count.
        /// </value>
        [J("seasonCount")] public long SeasonCount { get; set; }

        /// <summary>
        /// Gets or sets the total episode count.
        /// </summary>
        /// <value>
        /// The total episode count.
        /// </value>
        [J("totalEpisodeCount")] public long TotalEpisodeCount { get; set; }

        /// <summary>
        /// Gets or sets the episode count.
        /// </summary>
        /// <value>
        /// The episode count.
        /// </value>
        [J("episodeCount")] public long EpisodeCount { get; set; }

        /// <summary>
        /// Gets or sets the episode file count.
        /// </summary>
        /// <value>
        /// The episode file count.
        /// </value>
        [J("episodeFileCount")] public long EpisodeFileCount { get; set; }

        /// <summary>
        /// Gets or sets the size on disk.
        /// </summary>
        /// <value>
        /// The size on disk.
        /// </value>
        [J("sizeOnDisk")] public long SizeOnDisk { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        [J("status")] public string Status { get; set; }

        /// <summary>
        /// Gets or sets the overview.
        /// </summary>
        /// <value>
        /// The overview.
        /// </value>
        [J("overview")] public string Overview { get; set; }

        /// <summary>
        /// Gets or sets the previous airing.
        /// </summary>
        /// <value>
        /// The previous airing.
        /// </value>
        [J("previousAiring")] public DateTimeOffset PreviousAiring { get; set; }

        /// <summary>
        /// Gets or sets the network.
        /// </summary>
        /// <value>
        /// The network.
        /// </value>
        [J("network")] public string Network { get; set; }

        /// <summary>
        /// Gets or sets the air time.
        /// </summary>
        /// <value>
        /// The air time.
        /// </value>
        [J("airTime")] public string AirTime { get; set; }

        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        /// <value>
        /// The images.
        /// </value>
        [J("images")] public Image[] Images { get; set; }

        /// <summary>
        /// Gets or sets the seasons.
        /// </summary>
        /// <value>
        /// The seasons.
        /// </value>
        [J("seasons")] public Season[] Seasons { get; set; }

        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        /// <value>
        /// The year.
        /// </value>
        [J("year")] public long Year { get; set; }

        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>
        /// The path.
        /// </value>
        [J("path")] public string Path { get; set; }

        /// <summary>
        /// Gets or sets the profile identifier.
        /// </summary>
        /// <value>
        /// The profile identifier.
        /// </value>
        [J("profileId")] public long ProfileId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [season folder].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [season folder]; otherwise, <c>false</c>.
        /// </value>
        [J("seasonFolder")] public bool SeasonFolder { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Series"/> is monitored.
        /// </summary>
        /// <value>
        ///   <c>true</c> if monitored; otherwise, <c>false</c>.
        /// </value>
        [J("monitored")] public bool Monitored { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [use scene numbering].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [use scene numbering]; otherwise, <c>false</c>.
        /// </value>
        [J("useSceneNumbering")] public bool UseSceneNumbering { get; set; }

        /// <summary>
        /// Gets or sets the runtime.
        /// </summary>
        /// <value>
        /// The runtime.
        /// </value>
        [J("runtime")] public long Runtime { get; set; }

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
        /// Gets or sets the tv maze identifier.
        /// </summary>
        /// <value>
        /// The tv maze identifier.
        /// </value>
        [J("tvMazeId")] public long TvMazeId { get; set; }

        /// <summary>
        /// Gets or sets the first aired.
        /// </summary>
        /// <value>
        /// The first aired.
        /// </value>
        [J("firstAired")] public DateTimeOffset FirstAired { get; set; }

        /// <summary>
        /// Gets or sets the last information synchronize.
        /// </summary>
        /// <value>
        /// The last information synchronize.
        /// </value>
        [J("lastInfoSync")] public DateTimeOffset LastInfoSync { get; set; }

        /// <summary>
        /// Gets or sets the type of the series.
        /// </summary>
        /// <value>
        /// The type of the series.
        /// </value>
        [J("seriesType")] public string SeriesType { get; set; }

        /// <summary>
        /// Gets or sets the clean title.
        /// </summary>
        /// <value>
        /// The clean title.
        /// </value>
        [J("cleanTitle")] public string CleanTitle { get; set; }

        /// <summary>
        /// Gets or sets the imdb identifier.
        /// </summary>
        /// <value>
        /// The imdb identifier.
        /// </value>
        [J("imdbId")] public string ImdbId { get; set; }

        /// <summary>
        /// Gets or sets the title slug.
        /// </summary>
        /// <value>
        /// The title slug.
        /// </value>
        [J("titleSlug")] public string TitleSlug { get; set; }

        /// <summary>
        /// Gets or sets the certification.
        /// </summary>
        /// <value>
        /// The certification.
        /// </value>
        [J("certification")] public string Certification { get; set; }

        /// <summary>
        /// Gets or sets the genres.
        /// </summary>
        /// <value>
        /// The genres.
        /// </value>
        [J("genres")] public string[] Genres { get; set; }

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        /// <value>
        /// The tags.
        /// </value>
        [J("tags")] public object[] Tags { get; set; }

        /// <summary>
        /// Gets or sets the added.
        /// </summary>
        /// <value>
        /// The added.
        /// </value>
        [J("added")] public DateTimeOffset Added { get; set; }

        /// <summary>
        /// Gets or sets the ratings.
        /// </summary>
        /// <value>
        /// The ratings.
        /// </value>
        [J("ratings")] public Ratings Ratings { get; set; }

        /// <summary>
        /// Gets or sets the quality profile identifier.
        /// </summary>
        /// <value>
        /// The quality profile identifier.
        /// </value>
        [J("qualityProfileId")] public long QualityProfileId { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public long Id { get; set; }
    }
}
