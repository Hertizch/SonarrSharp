using Newtonsoft.Json;
using SonarrSharp.Helpers;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.SystemStatus
{
    public class SystemStatus : ISystemStatus
    {
        private SonarrClient _sonarrClient;

        public SystemStatus(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Returns system status
        /// </summary>
        /// <returns>Data.SystemStatus</returns>
        public async Task<Data.SystemStatus> GetSystemStatus()
        {
            var json = await _sonarrClient.GetJson("/system/status");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.SystemStatus>(json, JsonHelpers.SerializerSettings);

            return null;
        }
    }
}
