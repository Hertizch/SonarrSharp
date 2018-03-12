using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Parse.Data
{
    public partial class ParsedEpisodeInfo
    {
        [J("releaseTitle")] public string ReleaseTitle { get; set; }
        [J("seriesTitle")] public string SeriesTitle { get; set; }
        [J("seriesTitleInfo")] public SeriesTitleInfo SeriesTitleInfo { get; set; }
        [J("quality")] public ParsedEpisodeInfoQuality Quality { get; set; }
        [J("seasonNumber")] public long SeasonNumber { get; set; }
        [J("episodeNumbers")] public long[] EpisodeNumbers { get; set; }
        [J("absoluteEpisodeNumbers")] public object[] AbsoluteEpisodeNumbers { get; set; }
        [J("language")] public string Language { get; set; }
        [J("fullSeason")] public bool FullSeason { get; set; }
        [J("special")] public bool Special { get; set; }
        [J("releaseGroup")] public string ReleaseGroup { get; set; }
        [J("releaseHash")] public string ReleaseHash { get; set; }
        [J("isDaily")] public bool IsDaily { get; set; }
        [J("isAbsoluteNumbering")] public bool IsAbsoluteNumbering { get; set; }
        [J("isPossibleSpecialEpisode")] public bool IsPossibleSpecialEpisode { get; set; }
    }
}
