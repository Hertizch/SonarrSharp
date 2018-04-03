using Newtonsoft.Json;
using SonarrSharp.Helpers;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Queue
{
    /// <summary>
    /// Queue endpoint client
    /// </summary>
    public class Queue : IQueue
    {
        private SonarrClient _sonarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Queue"/> class.
        /// </summary>
        /// <param name="sonarrClient">The sonarr client.</param>
        public Queue(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Gets currently downloading info
        /// </summary>
        /// <returns></returns>
        public async Task<Models.Queue[]> GetQueue()
        {
            var json = await _sonarrClient.GetJson($"/queue");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Models.Queue[]>(json, Converter.Settings);

            return null;
        }

        /// <summary>
        /// Deletes an item from the queue and download client.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="blacklist">if set to <c>true</c> blacklist item after deletion.</param>
        /// <returns></returns>
        public async Task DeleteFromQueue(int id, [Optional] bool blacklist)
        {
            await _sonarrClient.Delete($"/queue/id={id}{(blacklist ? $"?blacklist={blacklist}" : "")}");
        }
    }
}
