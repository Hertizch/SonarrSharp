using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarrSharp;
using SonarrSharpUnitTest.Properties;

namespace SonarrSharpUnitTest
{
    [TestClass]
    public class CommandTest
    {
        private SonarrClient _sonarrClient = new SonarrClient(Resources.Host, int.Parse(Resources.Port), Resources.ApiKey, Resources.UrlBase) { WriteDebug = true };

        [TestMethod]
        public async Task GetCommands()
        {
            var obj = await _sonarrClient.Command.GetCommands();

            CollectionAssert.AllItemsAreNotNull(obj);
        }
    }
}
