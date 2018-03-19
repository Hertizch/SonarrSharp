using Newtonsoft.Json;
using SonarrSharp.Helpers;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.EpisodeFile
{
    /// <summary>
    /// EpisodeFile endpoint client
    /// </summary>
    class EpisodeFile : IEpisodeFile
    {
        private SonarrClient _sonarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="EpisodeFile"/> class.
        /// </summary>
        /// <param name="sonarrClient">The sonarr client.</param>
        public EpisodeFile(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Returns all episode files for the given series
        /// </summary>
        /// <param name="seriesId">Series ID</param>
        /// <returns>Data.EpisodeFile[]</returns>
        public async Task<Data.EpisodeFile[]> GetEpisodeFiles(int seriesId)
        {
            var json = await _sonarrClient.GetJson($"/episodeFile?seriesId={seriesId}");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.EpisodeFile[]>(json, JsonHelpers.SerializerSettings);

            return null;
        }

        /// <summary>
        /// Returns the episode file with the matching id
        /// </summary>
        /// <param name="episodeId">Episode ID</param>
        /// <returns>Data.EpisodeFile</returns>
        public async Task<Data.EpisodeFile> GetEpisodeFile(int episodeId)
        {
            var json = await _sonarrClient.GetJson($"/episodeFile/id={episodeId}");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.EpisodeFile>(json, JsonHelpers.SerializerSettings);

            return null;
        }

        /// <summary>
        /// Delete the given episode file
        /// </summary>
        /// <param name="id">Episode file ID</param>
        /// <returns>Nothing</returns>
        public async Task DeleteEpisodeFile(int id)
        {
            await _sonarrClient.Delete($"/episodeFile/id={id}");
        }
    }
}
