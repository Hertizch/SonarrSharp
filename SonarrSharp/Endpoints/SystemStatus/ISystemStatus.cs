using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.SystemStatus
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISystemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<Data.SystemStatus> GetSystemStatus();
    }
}
