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
        /// 
        /// </summary>
        [J("seriesId")] public long SeriesId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("seasonNumber")] public long SeasonNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("path")] public string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("size")] public long Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("dateAdded")] public DateTimeOffset DateAdded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("sceneName")] public string SceneName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("quality")] public EpisodeFileQuality Quality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("id")] public long Id { get; set; }
    }
}
