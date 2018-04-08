using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Calendar
{
    /// <summary>
    /// Calendar endpoint client
    /// </summary>
    public interface ICalendar
    {
        /// <summary>
        /// Gets upcoming episodes, if start/end are not supplied episodes airing today and tomorrow will be returned
        /// </summary>
        /// <returns></returns>
        Task<IList<Models.Calendar>> GetCalendar();

        /// <summary>
        /// Gets upcoming episodes, between the given time
        /// </summary>
        /// <param name="start">From date</param>
        /// <param name="end">To date</param>
        /// <returns></returns>
        Task<IList<Models.Calendar>> GetCalendar(DateTime start, DateTime end);
    }
}
