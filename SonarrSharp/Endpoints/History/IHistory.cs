using SonarrSharp.Enums;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.History
{
    public interface IHistory
    {
        Task<Data.History> GetHistory(string sortKey, [Optional] int page, [Optional] int pageSize, [Optional] SortDirection sortDirection);
    }
}
