using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Series.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Statistics
    {
        /// <summary>
        /// 
        /// </summary>
        [J("previousAiring")] public DateTimeOffset PreviousAiring { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("episodeFileCount")] public long EpisodeFileCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("episodeCount")] public long EpisodeCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("totalEpisodeCount")] public long TotalEpisodeCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("sizeOnDisk")] public long SizeOnDisk { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("percentOfEpisodes")] public long PercentOfEpisodes { get; set; }
    }
}
