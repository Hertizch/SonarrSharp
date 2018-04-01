using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Profile
{
    /// <summary>
    /// Profile endpoint client
    /// </summary>
    public interface IProfile
    {
        /// <summary>
        /// Gets all quality profiles
        /// </summary>
        /// <returns></returns>
        Task<Models.Profile[]> GetProfiles();
    }
}
