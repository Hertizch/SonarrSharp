using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.WantedMissing.Data
{
    public partial class Record
    {
        [J("seriesId")] public long SeriesId { get; set; }
        [J("episodeFileId")] public long EpisodeFileId { get; set; }
        [J("seasonNumber")] public long SeasonNumber { get; set; }
        [J("episodeNumber")] public long EpisodeNumber { get; set; }
        [J("title")] public string Title { get; set; }
        [J("airDate")] public DateTimeOffset AirDate { get; set; }
        [J("airDateUtc")] public DateTimeOffset AirDateUtc { get; set; }
        [J("overview")] public string Overview { get; set; }
        [J("hasFile")] public bool HasFile { get; set; }
        [J("monitored")] public bool Monitored { get; set; }
        [J("sceneEpisodeNumber")] public long SceneEpisodeNumber { get; set; }
        [J("sceneSeasonNumber")] public long SceneSeasonNumber { get; set; }
        [J("tvDbEpisodeId")] public long TvDbEpisodeId { get; set; }
        [J("absoluteEpisodeNumber")] public long AbsoluteEpisodeNumber { get; set; }
        [J("series")] public Series Series { get; set; }
        [J("downloading")] public bool Downloading { get; set; }
        [J("id")] public long Id { get; set; }
    }
}
