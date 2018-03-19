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
        /// <returns>Data.Queue[]</returns>
        Task<Data.Queue[]> GetQueue();
    }
}
