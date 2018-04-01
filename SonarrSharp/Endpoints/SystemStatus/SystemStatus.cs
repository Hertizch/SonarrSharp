using Newtonsoft.Json;
using SonarrSharp.Helpers;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.SystemStatus
{
    /// <summary>
    /// SystemStatus endpoint client
    /// </summary>
    public class SystemStatus : ISystemStatus
    {
        private SonarrClient _sonarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemStatus"/> class.
        /// </summary>
        /// <param name="sonarrClient">The sonarr client.</param>
        public SystemStatus(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Returns system status
        /// </summary>
        /// <returns></returns>
        public async Task<Models.SystemStatus> GetSystemStatus()
        {
            var json = await _sonarrClient.GetJson("/system/status");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Models.SystemStatus>(json, Converter.Settings);

            return null;
        }
    }
}
