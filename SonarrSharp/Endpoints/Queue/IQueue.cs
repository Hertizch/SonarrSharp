using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Queue
{
    /// <summary>
    /// Queue endpoint client
    /// </summary>
    public interface IQueue
    {
        /// <summary>
        /// Gets currently downloading info
        /// </summary>
        /// <returns></returns>
        Task<IList<Models.Queue>> GetQueue();

        /// <summary>
        /// Deletes an item from the queue and download client. Optionally blacklist item after deletion.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="blacklist">if set to <c>true</c> [blacklist].</param>
        /// <returns></returns>
        Task DeleteFromQueue(int id, [Optional] bool blacklist);
    }
}
