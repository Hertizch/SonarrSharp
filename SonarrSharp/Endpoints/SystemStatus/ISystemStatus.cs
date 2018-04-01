using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.SystemStatus
{
    /// <summary>
    /// SystemStatus endpoint client
    /// </summary>
    public interface ISystemStatus
    {
        /// <summary>
        /// Returns system status
        /// </summary>
        /// <returns></returns>
        Task<Models.SystemStatus> GetSystemStatus();
    }
}
