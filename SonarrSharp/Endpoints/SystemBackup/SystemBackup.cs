using Newtonsoft.Json;
using SonarrSharp.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.SystemBackup
{
    /// <summary>
    /// SystemBackup endpoint client
    /// </summary>
    public class SystemBackup : ISystemBackup
    {
        private SonarrClient _sonarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemBackup"/> class.
        /// </summary>
        /// <param name="sonarrClient">The sonarr client.</param>
        public SystemBackup(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Returns the list of available backups
        /// </summary>
        /// <returns></returns>
        public async Task<List<Models.SystemBackup>> GetSystemBackups()
        {
            var json = await _sonarrClient.GetJson($"/system/backup");
            return await Task.Run(() => JsonConvert.DeserializeObject<List<Models.SystemBackup>>(json, Converter.Settings));
        }
    }
}
