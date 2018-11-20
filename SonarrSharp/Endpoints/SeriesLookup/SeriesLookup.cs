using Newtonsoft.Json;
using SonarrSharp.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.SeriesLookup
{
    /// <summary>
    /// SeriesLookup endpoint client
    /// </summary>
    public class SeriesLookup : ISeriesLookup
    {
        private SonarrClient _sonarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesLookup"/> class.
        /// </summary>
        /// <param name="sonarrClient">The sonarr client.</param>
        public SeriesLookup(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Searches for new shows on trakt
        /// </summary>
        /// <param name="title">Series title</param>
        /// <returns></returns>
        public async Task<List<Models.SeriesLookup>> SearchForSeries(string title)
        {
            var json = await _sonarrClient.GetJson($"/series/lookup?term={title.Replace(" ", "%20")}");
            return await Task.Run(() => JsonConvert.DeserializeObject<List<Models.SeriesLookup>>(json, Converter.Settings));
        }

        /// <summary>
        /// Searches for new shows on trakt
        /// </summary>
        /// <param name="tvdbId">TV Database ID number</param>
        /// <returns></returns>
        public async Task<List<Models.SeriesLookup>> SearchForSeries(int tvdbId)
        {
            var json = await _sonarrClient.GetJson($"/series/lookup?term=tvdb:{tvdbId}");
            return await Task.Run(() => JsonConvert.DeserializeObject<List<Models.SeriesLookup>>(json, Converter.Settings));
        }
    }
}
