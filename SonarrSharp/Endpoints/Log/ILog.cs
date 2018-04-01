using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Log
{
    /// <summary>
    /// 
    /// </summary>
    public interface ILog
    {
        /// <summary>
        /// Gets the log files.
        /// </summary>
        /// <returns></returns>
        Task<Data.LogFile> GetLogFiles();

        /// <summary>
        /// Gets the log file.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <returns></returns>
        Task<string[]> GetLogFile(string filename);

        /// <summary>
        /// Gets the log.
        /// </summary>
        /// <returns></returns>
        Task<Data.Log> GetLog();
    }
}
