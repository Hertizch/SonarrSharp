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
        Task<Models.Queue[]> GetQueue();
    }
}
