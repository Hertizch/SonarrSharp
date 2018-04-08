using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarrSharp;
using SonarrSharpUnitTest.Properties;

namespace SonarrSharpUnitTest
{
    [TestClass]
    public class LogTest
    {
        private SonarrClient _sonarrClient = new SonarrClient(Resources.Host, int.Parse(Resources.Port), Resources.ApiKey, Resources.UrlBase) { WriteDebug = true };

        [TestMethod]
        public async Task GetLogFiles()
        {
            var obj = await _sonarrClient.Log.GetLogFiles();

            Assert.IsNotNull(obj);
        }

        [TestMethod]
        public async Task GetLogFile()
        {
            var obj = await _sonarrClient.Log.GetLogFile("sonarr.txt");

            Assert.IsNotNull(obj);
        }

        [TestMethod]
        public async Task GetLog()
        {
            var obj = await _sonarrClient.Log.GetLog();

            Assert.IsNotNull(obj);
        }
    }
}
