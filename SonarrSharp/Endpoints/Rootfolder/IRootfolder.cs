using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Rootfolder
{
    /// <summary>
    /// 
    /// </summary>
    public interface IRootfolder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<Data.Rootfolder[]> GetRootFolders();
    }
}
