using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.WantedMissing
{
    /// <summary>
    /// WantedMissing endpoint client
    /// </summary>
    public interface IWantedMissing
    {
        /// <summary>
        /// Gets missing episode (episodes without files)
        /// </summary>
        /// <param name="sortKey">Series title or airDateUtc</param>
        /// <param name="page">Page</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortDirection">Sort direction, asc or desc</param>
        /// <returns></returns>
        Task<Models.WantedMissing> GetMissing(string sortKey, [Optional] int page, [Optional] int pageSize, [Optional] string sortDirection);
    }
}
