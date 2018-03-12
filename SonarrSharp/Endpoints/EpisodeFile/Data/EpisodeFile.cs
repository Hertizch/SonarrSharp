using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.EpisodeFile.Data
{
    public partial class EpisodeFile
    {
        [J("seriesId")] public long SeriesId { get; set; }
        [J("seasonNumber")] public long SeasonNumber { get; set; }
        [J("path")] public string Path { get; set; }
        [J("size")] public long Size { get; set; }
        [J("dateAdded")] public DateTimeOffset DateAdded { get; set; }
        [J("sceneName")] public string SceneName { get; set; }
        [J("quality")] public EpisodeFileQuality Quality { get; set; }
        [J("id")] public long Id { get; set; }
    }
}
