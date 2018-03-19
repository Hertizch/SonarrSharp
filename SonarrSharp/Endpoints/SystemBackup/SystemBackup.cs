using Newtonsoft.Json;
using SonarrSharp.Helpers;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.SystemBackup
{
    /// <summary>
    /// 
    /// </summary>
    public class SystemBackup : ISystemBackup
    {
        private SonarrClient _sonarrClient;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sonarrClient"></param>
        public SystemBackup(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Returns the list of available backups
        /// </summary>
        /// <returns>Data.SystemBackup[]</returns>
        public async Task<Data.SystemBackup[]> GetSystemBackups()
        {
            var json = await _sonarrClient.GetJson($"/system/backup");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.SystemBackup[]>(json, JsonHelpers.SerializerSettings);

            return null;
        }
    }
}
