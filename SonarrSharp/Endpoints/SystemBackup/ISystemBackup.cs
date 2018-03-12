using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.SystemBackup
{
    public interface ISystemBackup
    {
        Task<Data.SystemBackup[]> GetSystemBackups();
    }
}
