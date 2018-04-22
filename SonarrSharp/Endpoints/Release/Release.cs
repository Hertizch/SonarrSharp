using Newtonsoft.Json;
using SonarrSharp.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Release
{
    /// <summary>
    /// Release endpoint client
    /// </summary>
    public class Release : IRelease
    {
        private SonarrClient _sonarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Release"/> class.
        /// </summary>
        /// <param name="sonarrClient">The sonarr client.</param>
        public Release(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Gets releases by episode ID from Sonarr's search cache (30 minute cache)
        /// </summary>
        /// <param name="episodeId">Episode ID</param>
        /// <returns></returns>
        public async Task<IList<Models.Release>> GetReleases(int episodeId)
        {
            var json = await _sonarrClient.GetJson($"/release");
            return await Task.Run(() => JsonConvert.DeserializeObject<IList<Models.Release>>(json, Converter.Settings));
        }

        /// <summary>
        /// Adds a previously searched release to the download client, if the release is still in Sonarr's search cache (30 minute cache)
        /// </summary>
        /// <param name="guid">Release GUID</param>
        /// <returns></returns>
        public async Task<IList<Models.Release>> AddRelease(string guid)
        {
            string parameter = JsonConvert.SerializeObject(new Dictionary<string, object>
            {
                ["guid"] = guid
            });

            var json = await _sonarrClient.PostJson($"/release", parameter, "POST");
            return await Task.Run(() => JsonConvert.DeserializeObject<IList<Models.Release>>(json, Converter.Settings));
        }
    }
}
