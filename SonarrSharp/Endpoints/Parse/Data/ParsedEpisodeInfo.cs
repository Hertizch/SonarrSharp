using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Parse.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ParsedEpisodeInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [J("releaseTitle")] public string ReleaseTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("seriesTitle")] public string SeriesTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("seriesTitleInfo")] public SeriesTitleInfo SeriesTitleInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("quality")] public ParsedEpisodeInfoQuality Quality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("seasonNumber")] public long SeasonNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("episodeNumbers")] public long[] EpisodeNumbers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("absoluteEpisodeNumbers")] public object[] AbsoluteEpisodeNumbers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("language")] public string Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("fullSeason")] public bool FullSeason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("special")] public bool Special { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("releaseGroup")] public string ReleaseGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("releaseHash")] public string ReleaseHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("isDaily")] public bool IsDaily { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("isAbsoluteNumbering")] public bool IsAbsoluteNumbering { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("isPossibleSpecialEpisode")] public bool IsPossibleSpecialEpisode { get; set; }
    }
}
