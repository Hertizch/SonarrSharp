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
        /// <returns>Data.SystemStatus</returns>
        Task<Data.SystemStatus> GetSystemStatus();
    }
}
