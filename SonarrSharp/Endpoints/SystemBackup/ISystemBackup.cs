using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.SystemBackup
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISystemBackup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<Data.SystemBackup[]> GetSystemBackups();
    }
}
