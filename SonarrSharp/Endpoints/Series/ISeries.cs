using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Series
{
    public interface ISeries
    {
        Task<Data.Series[]> GetSeries();
        Task<Data.Series> GetSeries(int seriesId);
        Task<Data.Series> AddSeries(int tvdbId, string title, int qualityProfileId, string titleSlug, Data.Image[] images, Data.Season[] seasons, string rootFolderPath, [Optional] int tvRageId, [Optional] bool seasonFolder, [Optional] bool monitored, [Optional] Dictionary<string, bool> addOptions);
        Task DeleteSeries(int id, [Optional] bool deleteFiles);
    }
}
