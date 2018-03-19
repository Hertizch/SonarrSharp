using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Rootfolder
{
    /// <summary>
    /// Rootfolder endpoint client
    /// </summary>
    public interface IRootfolder
    {
        /// <summary>
        /// Gets root folders
        /// </summary>
        /// <returns>Data.Rootfolder[]</returns>
        Task<Data.Rootfolder[]> GetRootFolders();
    }
}
