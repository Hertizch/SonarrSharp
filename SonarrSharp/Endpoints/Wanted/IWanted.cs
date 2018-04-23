using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Wanted
{
    /// <summary>
    /// Wanted endpoint client
    /// </summary>
    public interface IWanted
    {
        /// <summary>
        /// Gets missing episode (episodes without files)
        /// </summary>
        /// <param name="sortKey">Series title or airDateUtc</param>
        /// <param name="page">Page</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortDirection">Sort direction, asc or desc</param>
        /// <returns></returns>
        Task<Models.Wanted> GetMissing([Optional] string sortKey, [Optional] int page, [Optional] int pageSize, [Optional] string sortDirection);

        /// <summary>
        /// Returns episodes that has not achieved it's cutoff quality
        /// </summary>
        /// <param name="sortKey">Series title or airDateUtc</param>
        /// <param name="page">Page</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortDirection">Sort direction, asc or desc</param>
        /// <returns></returns>
        Task<Models.WantedCutoff> GetCutoffUnmet([Optional] string sortKey, [Optional] int page, [Optional] int pageSize, [Optional] string sortDirection);
    }
}
