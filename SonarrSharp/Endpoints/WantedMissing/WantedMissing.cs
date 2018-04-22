using Newtonsoft.Json;
using SonarrSharp.Helpers;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.WantedMissing
{
    /// <summary>
    /// WantedMissing endpoint client
    /// </summary>
    public class WantedMissing : IWantedMissing
    {
        private SonarrClient _sonarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="WantedMissing"/> class.
        /// </summary>
        /// <param name="sonarrClient">The sonarr client.</param>
        public WantedMissing(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Gets missing episode (episodes without files)
        /// </summary>
        /// <param name="sortKey">Series title or airDateUtc</param>
        /// <param name="page">Page</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortDirection">Sort direction, asc or desc</param>
        /// <returns></returns>
        public async Task<Models.WantedMissing> GetMissing(string sortKey, [Optional] int page, [Optional] int pageSize, [Optional] string sortDirection)
        {
            var json = await _sonarrClient.GetJson($"/wanted/missing?sortKey={sortKey}" +
                $"{(page != 0 ? "&page=" + page : "")}" +
                $"{(pageSize != 0 ? "&pageSize=" + pageSize : "")}" +
                $"{(sortDirection != null ? "&sortDirection=" + sortDirection : "")}");
            return await Task.Run(() => JsonConvert.DeserializeObject<Models.WantedMissing>(json, Converter.Settings));
        }
    }
}
