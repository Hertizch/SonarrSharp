using Newtonsoft.Json;
using SonarrSharp.Helpers;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Diskspace
{
    /// <summary>
    /// Diskspace endpoint client
    /// </summary>
    public class Diskspace : IDiskspace
    {
        private SonarrClient _sonarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Diskspace"/> class.
        /// </summary>
        /// <param name="sonarrClient">The sonarr client.</param>
        public Diskspace(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Gets information about Diskspace
        /// </summary>
        /// <returns></returns>
        public async Task<Models.Diskspace[]> GetDiskspace()
        {
            var json = await _sonarrClient.GetJson("/diskspace");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Models.Diskspace[]>(json, Converter.Settings);

            return null;
        }
    }
}
