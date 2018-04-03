using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Series
{
    /// <summary>
    /// 
    /// </summary>
    public class AddOptions
    {
        /// <summary>
        /// Gets or sets a value indicating whether [ignore episodes with files].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [ignore episodes with files]; otherwise, <c>false</c>.
        /// </value>
        [J("ignoreEpisodesWithFiles")] public bool IgnoreEpisodesWithFiles { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [ignore episodes without files].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [ignore episodes without files]; otherwise, <c>false</c>.
        /// </value>
        [J("ignoreEpisodesWithoutFiles")] public bool IgnoreEpisodesWithoutFiles { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [search for missing episodes].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [search for missing episodes]; otherwise, <c>false</c>.
        /// </value>
        [J("searchForMissingEpisodes")] public bool SearchForMissingEpisodes { get; set; }
    }
}
