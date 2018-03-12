using System.Collections.Generic;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Diskspace
{
    public interface IDiskspace
    {
        Task<Data.Diskspace[]> GetDiskspace();
    }
}
