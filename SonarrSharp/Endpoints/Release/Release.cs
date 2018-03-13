using Newtonsoft.Json;
using SonarrSharp.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Release
{
    public class Release : IRelease
    {
        private SonarrClient _sonarrClient;

        public Release(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Gets releases by episode ID from Sonarr's search cache (30 minute cache)
        /// </summary>
        /// <param name="episodeId">Episode ID</param>
        /// <returns>Data.Release[]</returns>
        public async Task<Data.Release[]> GetReleases(int episodeId)
        {
            var json = await _sonarrClient.GetJson($"/release");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.Release[]>(json, JsonHelpers.SerializerSettings);

            return null;
        }

        /// <summary>
        /// Adds a previously searched release to the download client, if the release is still in Sonarr's search cache (30 minute cache)
        /// </summary>
        /// <param name="guid">Release GUID</param>
        /// <returns>Data.Release[]</returns>
        public async Task<Data.Release[]> AddRelease(string guid)
        {
            string parameter = JsonConvert.SerializeObject(new Dictionary<string, object>
            {
                ["guid"] = guid
            });

            var json = await _sonarrClient.PostJson($"/release", parameter, "POST");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.Release[]>(json, JsonHelpers.SerializerSettings);

            return null;
        }
    }
}
