using System.Collections.Generic;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Diskspace
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDiskspace
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<Data.Diskspace[]> GetDiskspace();
    }
}
