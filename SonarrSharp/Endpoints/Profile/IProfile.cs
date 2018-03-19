using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Profile
{
    /// <summary>
    /// 
    /// </summary>
    public interface IProfile
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<Data.Profile[]> GetProfiles();
    }
}
