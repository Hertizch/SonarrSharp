using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Parse
{
    public interface IParse
    {
        Task<Data.Parse> ParseTitle(string title);
        Task<Data.Parse> ParsePath(string path);
    }
}
