using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.History
{
    /// <summary>
    /// History endpoint client
    /// </summary>
    public interface IHistory
    {
        /// <summary>
        /// Gets history (grabs/failures/completed)
        /// </summary>
        /// <param name="sortKey">Series title or Date</param>
        /// <param name="page">Page</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortDirection">Sort direction, asc or desc</param>
        /// <returns></returns>
        Task<Models.History> GetHistory(string sortKey, [Optional] int page, [Optional] int pageSize, [Optional] string sortDirection);
    }
}
