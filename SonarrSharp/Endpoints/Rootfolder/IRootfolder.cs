using System.Collections.Generic;
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
        /// <returns></returns>
        Task<IList<Models.Rootfolder>> GetRootFolders();
    }
}
