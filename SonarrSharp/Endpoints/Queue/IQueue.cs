using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Queue
{
    /// <summary>
    /// 
    /// </summary>
    public interface IQueue
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<Data.Queue[]> GetQueue();
    }
}
