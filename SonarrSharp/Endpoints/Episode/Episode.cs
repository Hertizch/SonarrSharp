using Newtonsoft.Json;
using SonarrSharp.Helpers;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Episode
{
    /// <summary>
    /// Episode endpoint client
    /// </summary>
    public class Episode : IEpisode
    {
        private SonarrClient _sonarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Episode"/> class.
        /// </summary>
        /// <param name="sonarrClient">The sonarr client.</param>
        public Episode(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Returns all episodes for the given series
        /// </summary>
        /// <param name="seriesId">Series ID</param>
        /// <returns></returns>
        public async Task<Models.Episode[]> GetEpisodes(int seriesId)
        {
            var json = await _sonarrClient.GetJson($"/episode?seriesId={seriesId}");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Models.Episode[]>(json, Converter.Settings);

            return null;
        }

        /// <summary>
        /// Returns the episode with the matching id
        /// </summary>
        /// <param name="episodeId">Episode ID</param>
        /// <returns></returns>
        public async Task<Models.Episode> GetEpisode(int episodeId)
        {
            var json = await _sonarrClient.GetJson($"/episode/id={episodeId}");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Models.Episode>(json, Converter.Settings);

            return null;
        }

        /// <summary>
        /// Update the given episodes, currently only monitored is changed, all other modifications are ignored.
        /// </summary>
        /// <param name="episode">Episode to update - Requires all properties of Models.Episode object</param>
        /// <returns></returns>
        public async Task<Models.Episode> UpdateEpisode(Models.Episode episode)
        {
            var json = await _sonarrClient.PostJson("/command", JsonConvert.SerializeObject(episode), "PUT");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Models.Episode>(json, Converter.Settings);

            return null;
        }
    }
}
