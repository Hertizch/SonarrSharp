using Newtonsoft.Json;
using SonarrSharp.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Diskspace
{
    public class Diskspace : IDiskspace
    {
        private SonarrClient _sonarrClient;

        public Diskspace(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Gets information about Diskspace
        /// </summary>
        /// <returns>Data.Diskspace[]</returns>
        public async Task<Data.Diskspace[]> GetDiskspace()
        {
            var json = await _sonarrClient.GetJson("/diskspace");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.Diskspace[]>(json, JsonHelpers.SerializerSettings);

            return null;
        }
    }
}
