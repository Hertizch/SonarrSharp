using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SonarrSharp;

namespace SonarrSharpUnitTest
{
    public interface ISonarrClient
    {
        SonarrClient SonarrClient { get; set; }
        string Host { get; set; }
    }
}
