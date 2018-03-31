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
        /// <returns>Data.Rootfolder[]</returns>
        public async Task<Data.Rootfolder[]> GetRootFolders()
        {
            var json = await _sonarrClient.GetJson($"/rootfolder");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.Rootfolder[]>(json, Converter.Settings);

            return null;
        }
    }
}
