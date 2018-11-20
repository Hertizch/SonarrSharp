using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarrSharp;
using SonarrSharpUnitTest.Properties;

namespace SonarrSharpUnitTest
{
    [TestClass]
    public class EpisodeTest
    {
        private SonarrClient _sonarrClient = new SonarrClient(Resources.Host, int.Parse(Resources.Port), Resources.ApiKey, Resources.UrlBase) { WriteDebug = true };

        [TestMethod]
        public async Task UpdateEpisode()
        {
            //var episode = await _sonarrClient.Episode.GetEpisode(45);

            //episode.Monitored = true;

            //var obj = await _sonarrClient.Episode.UpdateEpisode(episode);

            //Assert.IsNotNull(episodes);
        }

        [TestMethod]
        public async Task GetSeries()
        {
            var series = await _sonarrClient.Series.GetSeries();
            foreach (var serie in series)
            {
                Console.WriteLine($"{serie.Id}: {serie.Title}");
            }
        }

        [TestMethod]
        public async Task GetEpisodes()
        {
            var episodes = await _sonarrClient.Episode.GetEpisodes(1);
            foreach (var episode in episodes)
            {
                Console.WriteLine($"{episode.Id}: {episode.Title}");
            }
        }
    }
}
