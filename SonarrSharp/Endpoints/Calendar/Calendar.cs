using Newtonsoft.Json;
using SonarrSharp.Helpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Calendar
{
    /// <summary>
    /// Calendar endpoint client
    /// </summary>
    public class Calendar : ICalendar
    {
        private SonarrClient _sonarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Calendar"/> class.
        /// </summary>
        /// <param name="sonarrClient">The sonarr client.</param>
        public Calendar(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Gets upcoming episodes, if start/end are not supplied episodes airing today and tomorrow will be returned
        /// </summary>
        /// <returns></returns>
        public async Task<List<Models.Calendar>> GetCalendar()
        {
            var json = await _sonarrClient.GetJson($"/calendar");
            return await Task.Run(() => JsonConvert.DeserializeObject<List<Models.Calendar>>(json, Converter.Settings));
        }

        /// <summary>
        /// Gets upcoming episodes, between the given time
        /// </summary>
        /// <param name="start">From date</param>
        /// <param name="end">To date</param>
        /// <returns></returns>
        public async Task<List<Models.Calendar>> GetCalendar(DateTime start, DateTime end)
        {
            var json = await _sonarrClient.GetJson($"/calendar?start={start.ToString("yyyy-MM-dd")}&end={end.ToString("yyyy-MM-dd")}");
            return await Task.Run(() => JsonConvert.DeserializeObject<List<Models.Calendar>>(json, Converter.Settings));
        }
    }
}
