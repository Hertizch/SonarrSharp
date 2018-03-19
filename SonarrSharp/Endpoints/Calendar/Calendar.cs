using Newtonsoft.Json;
using SonarrSharp.Helpers;
using System;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Calendar
{
    /// <summary>
    /// 
    /// </summary>
    public class Calendar : ICalendar
    {
        private SonarrClient _sonarrClient;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sonarrClient"></param>
        public Calendar(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Gets upcoming episodes, if start/end are not supplied episodes airing today and tomorrow will be returned
        /// </summary>
        /// <returns>Data.Calendar[]</returns>
        public async Task<Data.Calendar[]> GetCalendar()
        {
            var json = await _sonarrClient.GetJson($"/calendar");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.Calendar[]>(json, JsonHelpers.SerializerSettings);

            return null;
        }

        /// <summary>
        /// Gets upcoming episodes, between the given time
        /// </summary>
        /// <param name="start">From date</param>
        /// <param name="end">To date</param>
        /// <returns>Data.Calendar[]</returns>
        public async Task<Data.Calendar[]> GetCalendar(DateTime start, DateTime end)
        {
            var json = await _sonarrClient.GetJson($"/calendar?start={start.ToString("yyyy-MM-dd")}&end={end.ToString("yyyy-MM-dd")}");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.Calendar[]>(json, JsonHelpers.SerializerSettings);

            return null;
        }
    }
}
