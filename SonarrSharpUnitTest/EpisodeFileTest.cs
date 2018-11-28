using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarrSharp;
using SonarrSharpUnitTest.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonarrSharpUnitTest
{
    [TestClass]
    public class EpisodeFileTest
    {
        private SonarrClient _sonarrClient = new SonarrClient(Resources.Host, int.Parse(Resources.Port), Resources.ApiKey, Resources.UrlBase) { WriteDebug = true };

        [TestMethod]
        public async Task DeleteEpisodeFile()
        {
            var episodeFiles = await _sonarrClient.EpisodeFile.GetEpisodeFiles(1);
            foreach (var episodeFile in episodeFiles)
            {
                Console.WriteLine($"{episodeFile.Id}: {episodeFile.Path}");
            }

            await _sonarrClient.EpisodeFile.DeleteEpisodeFile(1);
        }
    }
}
