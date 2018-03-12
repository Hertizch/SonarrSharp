using Newtonsoft.Json;
using SonarrSharp.Helpers;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.SeriesLookup
{
    public class SeriesLookup : ISeriesLookup
    {
        private SonarrClient _sonarrClient;

        public SeriesLookup(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Searches for new shows on trakt
        /// </summary>
        /// <param name="term">Series name</param>
        /// <returns>Data.SeriesLookup[]</returns>
        public async Task<Data.SeriesLookup[]> SearchForSeries(string title)
        {
            var json = await _sonarrClient.GetJson($"/series/lookup?term={title.Replace(" ", "%20")}");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.SeriesLookup[]>(json, JsonHelpers.SerializerSettings);

            return null;
        }

        /// <summary>
        /// Searches for new shows on trakt
        /// </summary>
        /// <param name="tvdbId">TV Database ID number</param>
        /// <returns>Data.SeriesLookup[]</returns>
        public async Task<Data.SeriesLookup[]> SearchForSeries(int tvdbId)
        {
            var json = await _sonarrClient.GetJson($"/series/lookup?term=tvdb:{tvdbId}");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.SeriesLookup[]>(json, JsonHelpers.SerializerSettings);

            return null;
        }
    }
}
