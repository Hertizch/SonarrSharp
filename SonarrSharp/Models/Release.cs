using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Release
    {
        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>
        /// <value>
        /// The unique identifier.
        /// </value>
        [J("guid")] public string Guid { get; set; }

        /// <summary>
        /// Gets or sets the quality.
        /// </summary>
        /// <value>
        /// The quality.
        /// </value>
        [J("quality")] public ReleaseQuality Quality { get; set; }

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        [J("age")] public long Age { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        [J("size")] public long Size { get; set; }

        /// <summary>
        /// Gets or sets the indexer.
        /// </summary>
        /// <value>
        /// The indexer.
        /// </value>
        [J("indexer")] public string Indexer { get; set; }

        /// <summary>
        /// Gets or sets the release group.
        /// </summary>
        /// <value>
        /// The release group.
        /// </value>
        [J("releaseGroup")] public string ReleaseGroup { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [J("title")] public string Title { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [full season].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [full season]; otherwise, <c>false</c>.
        /// </value>
        [J("fullSeason")] public bool FullSeason { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [scene source].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [scene source]; otherwise, <c>false</c>.
        /// </value>
        [J("sceneSource")] public bool SceneSource { get; set; }

        /// <summary>
        /// Gets or sets the season number.
        /// </summary>
        /// <value>
        /// The season number.
        /// </value>
        [J("seasonNumber")] public long SeasonNumber { get; set; }

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        /// <value>
        /// The language.
        /// </value>
        [J("language")] public string Language { get; set; }

        /// <summary>
        /// Gets or sets the series title.
        /// </summary>
        /// <value>
        /// The series title.
        /// </value>
        [J("seriesTitle")] public string SeriesTitle { get; set; }

        /// <summary>
        /// Gets or sets the episode numbers.
        /// </summary>
        /// <value>
        /// The episode numbers.
        /// </value>
        [J("episodeNumbers")] public long[] EpisodeNumbers { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Release"/> is approved.
        /// </summary>
        /// <value>
        ///   <c>true</c> if approved; otherwise, <c>false</c>.
        /// </value>
        [J("approved")] public bool Approved { get; set; }

        /// <summary>
        /// Gets or sets the tv rage identifier.
        /// </summary>
        /// <value>
        /// The tv rage identifier.
        /// </value>
        [J("tvRageId")] public long TvRageId { get; set; }

        /// <summary>
        /// Gets or sets the rejections.
        /// </summary>
        /// <value>
        /// The rejections.
        /// </value>
        [J("rejections")] public string[] Rejections { get; set; }

        /// <summary>
        /// Gets or sets the publish date.
        /// </summary>
        /// <value>
        /// The publish date.
        /// </value>
        [J("publishDate")] public DateTimeOffset PublishDate { get; set; }

        /// <summary>
        /// Gets or sets the download URL.
        /// </summary>
        /// <value>
        /// The download URL.
        /// </value>
        [J("downloadUrl")] public string DownloadUrl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [download allowed].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [download allowed]; otherwise, <c>false</c>.
        /// </value>
        [J("downloadAllowed")] public bool DownloadAllowed { get; set; }
    }
}
