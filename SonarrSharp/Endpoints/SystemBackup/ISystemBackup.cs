using System.Collections.Generic;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.SystemBackup
{
    /// <summary>
    /// SystemBackup endpoint client
    /// </summary>
    public interface ISystemBackup
    {
        /// <summary>
        /// Returns the list of available backups
        /// </summary>
        /// <returns></returns>
        Task<IList<Models.SystemBackup>> GetSystemBackups();
    }
}
