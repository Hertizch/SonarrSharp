using Newtonsoft.Json;
using SonarrSharp.Enums;
using SonarrSharp.Helpers;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.WantedMissing
{
    /// <summary>
    /// 
    /// </summary>
    public class WantedMissing : IWantedMissing
    {
        private SonarrClient _sonarrClient;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sonarrClient"></param>
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
        /// <param name="sortDirection">Sort direction</param>
        /// <returns>Data.WantedMissing</returns>
        public async Task<Data.WantedMissing> GetMissing(string sortKey, [Optional] int page, [Optional] int pageSize, [Optional] SortDirection sortDirection)
        {
            var json = await _sonarrClient.GetJson($"/wanted/missing?sortKey={sortKey}" +
                $"{(page != 0 ? "&page=" + page : "")}" +
                $"{(pageSize != 0 ? "&pageSize=" + pageSize : "")}" +
                $"{(sortDirection != 0 ? "&sortDirection=" + sortDirection.ToString().ToLower() : "")}");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.WantedMissing>(json, JsonHelpers.SerializerSettings);

            return null;
        }
    }
}
