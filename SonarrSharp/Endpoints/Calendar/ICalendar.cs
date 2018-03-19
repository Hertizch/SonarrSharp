using System;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Calendar
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICalendar
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<Data.Calendar[]> GetCalendar();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        Task<Data.Calendar[]> GetCalendar(DateTime start, DateTime end);
    }
}
