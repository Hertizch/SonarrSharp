using Newtonsoft.Json;
using SonarrSharp.Helpers;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Parse
{
    /// <summary>
    /// Parse endpoint client
    /// </summary>
    public class Parse : IParse
    {
        private SonarrClient _sonarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Parse"/> class.
        /// </summary>
        /// <param name="sonarrClient">The sonarr client.</param>
        public Parse(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Returns the result of parsing a title
        /// </summary>
        /// <param name="title">Title</param>
        /// <returns>Data.Parse</returns>
        public async Task<Data.Parse> ParseTitle(string title)
        {
            var json = await _sonarrClient.GetJson($"/parse?title={title}");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.Parse>(json, JsonHelpers.SerializerSettings);

            return null;
        }

        /// <summary>
        /// Returns the result of parsing a path
        /// </summary>
        /// <param name="path">Path</param>
        /// <returns>Data.Parse</returns>
        public async Task<Data.Parse> ParsePath(string path)
        {
            var json = await _sonarrClient.GetJson($"/parse?path={path}");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.Parse>(json, JsonHelpers.SerializerSettings);

            return null;
        }
    }
}
