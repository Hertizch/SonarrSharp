using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Rootfolder
{
    public interface IRootfolder
    {
        Task<Data.Rootfolder[]> GetRootFolders();
    }
}
