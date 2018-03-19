using SonarrSharp.Enums;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.WantedMissing
{
    /// <summary>
    /// 
    /// </summary>
    public interface IWantedMissing
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sortKey"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="sortDirection"></param>
        /// <returns></returns>
        Task<Data.WantedMissing> GetMissing(string sortKey, [Optional] int page, [Optional] int pageSize, [Optional] SortDirection sortDirection);
    }
}
