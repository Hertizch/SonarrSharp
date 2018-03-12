using SonarrSharp.Enums;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.WantedMissing
{
    public interface IWantedMissing
    {
        Task<Data.WantedMissing> GetMissing(string sortKey, [Optional] int page, [Optional] int pageSize, [Optional] SortDirection sortDirection);
    }
}
