using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Series.Data
{
    public partial class Statistics
    {
        [J("previousAiring")] public DateTimeOffset PreviousAiring { get; set; }
        [J("episodeFileCount")] public long EpisodeFileCount { get; set; }
        [J("episodeCount")] public long EpisodeCount { get; set; }
        [J("totalEpisodeCount")] public long TotalEpisodeCount { get; set; }
        [J("sizeOnDisk")] public long SizeOnDisk { get; set; }
        [J("percentOfEpisodes")] public long PercentOfEpisodes { get; set; }
    }
}
