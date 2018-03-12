using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Profile
{
    public interface IProfile
    {
        Task<Data.Profile[]> GetProfiles();
    }
}
