using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.SystemStatus
{
    public interface ISystemStatus
    {
        Task<Data.SystemStatus> GetSystemStatus();
    }
}
