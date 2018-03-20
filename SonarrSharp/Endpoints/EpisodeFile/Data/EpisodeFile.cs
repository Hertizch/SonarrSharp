using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.EpisodeFile.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class EpisodeFile
    {
        /// <summary>
        /// Gets or sets the series identifier.
        /// </summary>
        /// <value>
        /// The series identifier.
        /// </value>
        [J("seriesId")] public long SeriesId { get; set; }

        /// <summary>
        /// Gets or sets the season number.
        /// </summary>
        /// <value>
        /// The season number.
        /// </value>
        [J("seasonNumber")] public long SeasonNumber { get; set; }

        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>
        /// The path.
        /// </value>
        [J("path")] public string Path { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        [J("size")] public long Size { get; set; }

        /// <summary>
        /// Gets or sets the date added.
        /// </summary>
        /// <value>
        /// The date added.
        /// </value>
        [J("dateAdded")] public DateTimeOffset DateAdded { get; set; }

        /// <summary>
        /// Gets or sets the name of the scene.
        /// </summary>
        /// <value>
        /// The name of the scene.
        /// </value>
        [J("sceneName")] public string SceneName { get; set; }

        /// <summary>
        /// Gets or sets the quality.
        /// </summary>
        /// <value>
        /// The quality.
        /// </value>
        [J("quality")] public EpisodeFileQuality Quality { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public long Id { get; set; }
    }
}
