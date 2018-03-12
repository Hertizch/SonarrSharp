using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Queue
{
    public interface IQueue
    {
        Task<Data.Queue[]> GetQueue();
    }
}
