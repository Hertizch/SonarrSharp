using Newtonsoft.Json;
using SonarrSharp.Helpers;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Wanted
{
    /// <summary>
    /// Wanted endpoint client
    /// </summary>
    public class Wanted : IWanted
    {
        private SonarrClient _sonarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Wanted"/> class.
        /// </summary>
        /// <param name="sonarrClient">The sonarr client.</param>
        public Wanted(SonarrClient sonarrClient)
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
        public async Task<Models.Wanted> GetMissing([Optional] string sortKey, [Optional] int page, [Optional] int pageSize, [Optional] string sortDirection)
        {
            var param = new Dictionary<string, object>();

            if (sortKey != null)
                param.Add("sortKey", sortKey);

            if (page != 0)
                param.Add("page", page);

            if (pageSize != 0)
                param.Add("pageSize", pageSize);

            if (sortDirection != null)
                param.Add("sortDir", sortDirection);

            var json = await _sonarrClient.GetJson($"/wanted/missing{ParameterHelper.BuildParameterString(param)}");
            return await Task.Run(() => JsonConvert.DeserializeObject<Models.Wanted>(json, Converter.Settings));
        }

        /// <summary>
        /// Returns episodes that has not achieved it's cutoff quality
        /// </summary>
        /// <param name="sortKey">Series title or airDateUtc</param>
        /// <param name="page">Page</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortDirection">Sort direction, asc or desc</param>
        /// <returns></returns>
        public async Task<Models.WantedCutoff> GetCutoffUnmet([Optional] string sortKey, [Optional] int page, [Optional] int pageSize, [Optional] string sortDirection)
        {
            var param = new Dictionary<string, object>();

            if (sortKey != null)
                param.Add("sortKey", sortKey);

            if (page != 0)
                param.Add("page", page);

            if (pageSize != 0)
                param.Add("pageSize", pageSize);

            if (sortDirection != null)
                param.Add("sortDir", sortDirection);

            var json = await _sonarrClient.GetJson($"/wanted/cutoff{ParameterHelper.BuildParameterString(param)}");
            return await Task.Run(() => JsonConvert.DeserializeObject<Models.WantedCutoff>(json, Converter.Settings));
        }
    }
}
