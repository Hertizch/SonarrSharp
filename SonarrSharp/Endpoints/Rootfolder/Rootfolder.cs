using Newtonsoft.Json;
using SonarrSharp.Helpers;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Rootfolder
{
    /// <summary>
    /// Rootfolder endpoint client
    /// </summary>
    public class Rootfolder : IRootfolder
    {
        private SonarrClient _sonarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Rootfolder"/> class.
        /// </summary>
        /// <param name="sonarrClient">The sonarr client.</param>
        public Rootfolder(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Gets root folders
        /// </summary>
        /// <returns></returns>
        public async Task<Models.Rootfolder[]> GetRootFolders()
        {
            var json = await _sonarrClient.GetJson($"/rootfolder");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Models.Rootfolder[]>(json, Converter.Settings);

            return null;
        }
    }
}
