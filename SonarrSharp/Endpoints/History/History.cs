using Newtonsoft.Json;
using SonarrSharp.Enums;
using SonarrSharp.Helpers;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.History
{
    /// <summary>
    /// History endpoint client
    /// </summary>
    public class History : IHistory
    {
        private SonarrClient _sonarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="History"/> class.
        /// </summary>
        /// <param name="sonarrClient">The sonarr client.</param>
        public History(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Gets history (grabs/failures/completed)
        /// </summary>
        /// <param name="sortKey">Series title or Date</param>
        /// <param name="page">Page</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortDirection">Sort direction</param>
        /// <returns>Data.History</returns>
        public async Task<Data.History> GetHistory(string sortKey, [Optional] int page, [Optional] int pageSize, [Optional] SortDirection sortDirection)
        {
            var json = await _sonarrClient.GetJson($"/history?sortKey={sortKey}" +
                $"{(page != 0 ? "&page=" + page : "")}" +
                $"{(pageSize != 0 ? "&pageSize=" + pageSize : "")}" +
                $"{(sortDirection != 0 ? "&sortDirection=" + sortDirection.ToString().ToLower() : "")}");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.History>(json, Converter.Settings);

            return null;
        }
    }
}
