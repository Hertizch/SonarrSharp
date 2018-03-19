using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.ReleasePush.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ReleasePush
    {
        /// <summary>
        /// 
        /// </summary>
        [J("guid")] public string Guid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("quality")] public ReleasePushQuality Quality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("age")] public long Age { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("size")] public long Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("indexer")] public string Indexer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("releaseGroup")] public string ReleaseGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("title")] public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("fullSeason")] public bool FullSeason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("sceneSource")] public bool SceneSource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("seasonNumber")] public long SeasonNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("language")] public string Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("seriesTitle")] public string SeriesTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("episodeNumbers")] public long[] EpisodeNumbers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("approved")] public bool Approved { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("tvRageId")] public long TvRageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("rejections")] public string[] Rejections { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("publishDate")] public DateTimeOffset PublishDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("downloadUrl")] public string DownloadUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("downloadAllowed")] public bool DownloadAllowed { get; set; }
    }
}
