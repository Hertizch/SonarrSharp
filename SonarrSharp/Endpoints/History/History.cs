using Newtonsoft.Json;
using SonarrSharp.Helpers;
using System.Text;
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
        /// <param name="sortKey">Series title or Date - Default date</param>
        /// <param name="page">Page - Default 1</param>
        /// <param name="pageSize">Page size - Default 10</param>
        /// <param name="sortDir">Sort direction, asc or desc - Default desc</param>
        /// <returns></returns>
        public async Task<Models.History> GetHistory(string sortKey, int page = 1, int pageSize = 10, string sortDir = "default")
        {
            var sb = new StringBuilder();
            sb.Append($"?sortKey={sortKey}");
            sb.Append($"&page={page}");
            sb.Append($"&pageSize={pageSize}");
            sb.Append($"&sortDir={sortDir}");

            var json = await _sonarrClient.GetJson($"/history{sb.ToString()}");
            return await Task.Run(() => JsonConvert.DeserializeObject<Models.History>(json, Converter.Settings));
        }
    }
}
