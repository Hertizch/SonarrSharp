using System;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Calendar
{
    public interface ICalendar
    {
        Task<Data.Calendar[]> GetCalendar();
        Task<Data.Calendar[]> GetCalendar(DateTime start, DateTime end);
    }
}
