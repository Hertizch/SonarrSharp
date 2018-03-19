using SonarrSharp.Enums;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.History
{
    /// <summary>
    /// 
    /// </summary>
    public interface IHistory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sortKey"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="sortDirection"></param>
        /// <returns></returns>
        Task<Data.History> GetHistory(string sortKey, [Optional] int page, [Optional] int pageSize, [Optional] SortDirection sortDirection);
    }
}
