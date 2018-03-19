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
        /// <returns>Data.SystemBackup[]</returns>
        Task<Data.SystemBackup[]> GetSystemBackups();
    }
}
