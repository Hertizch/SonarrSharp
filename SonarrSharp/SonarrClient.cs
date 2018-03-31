using SonarrSharp.Endpoints.Calendar;
using SonarrSharp.Endpoints.Command;
using SonarrSharp.Endpoints.Diskspace;
using SonarrSharp.Endpoints.Episode;
using SonarrSharp.Endpoints.EpisodeFile;
using SonarrSharp.Endpoints.History;
using SonarrSharp.Endpoints.Log;
using SonarrSharp.Endpoints.Parse;
using SonarrSharp.Endpoints.Profile;
using SonarrSharp.Endpoints.Queue;
using SonarrSharp.Endpoints.Release;
using SonarrSharp.Endpoints.ReleasePush;
using SonarrSharp.Endpoints.Rootfolder;
using SonarrSharp.Endpoints.Series;
using SonarrSharp.Endpoints.SeriesLookup;
using SonarrSharp.Endpoints.SystemBackup;
using SonarrSharp.Endpoints.SystemStatus;
using SonarrSharp.Endpoints.WantedMissing;
using SonarrSharp.Helpers;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SonarrSharp
{
    /// <summary>
    /// SonarrClient
    /// </summary>
    public class SonarrClient
    {
        private WebClient _webClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="SonarrClient"/> class.
        /// </summary>
        /// <param name="host">The host.</param>
        /// <param name="port">The port.</param>
        /// <param name="apiKey">The API key.</param>
        /// <param name="urlBase">The URL base.</param>
        /// <param name="useSsl">if set to <c>true</c> [use SSL].</param>
        public SonarrClient(string host, int port, string apiKey, [Optional] string urlBase, [Optional] bool useSsl)
        {
            // Initialize properties
            Host = host;
            Port = port;
            ApiKey = apiKey;
            UrlBase = urlBase;
            UseSsl = useSsl;

            // Set API URL
            ApiUrl = $"http{(UseSsl ? "s" : "")}://{Host}:{Port}{("/" + UrlBase ?? "")}/api";

            // Initialize endpoints
            Calendar = new Calendar(this);
            Command = new Command(this);
            Diskspace = new Diskspace(this);
            Episode = new Episode(this);
            EpisodeFile = new EpisodeFile(this);
            History = new History(this);
            WantedMissing = new WantedMissing(this);
            Queue = new Queue(this);
            Parse = new Parse(this);
            Profile = new Profile(this);
            Release = new Release(this);
            ReleasePush = new ReleasePush(this);
            Rootfolder = new Rootfolder(this);
            Series = new Series(this);
            SeriesLookup = new SeriesLookup(this);
            SystemStatus = new SystemStatus(this);
            SystemBackup = new SystemBackup(this);
            Log = new Log(this);
        }

        /// <summary>
        /// Gets the host.
        /// </summary>
        /// <value>
        /// The host.
        /// </value>
        public string Host { get; private set; }

        /// <summary>
        /// Gets the port.
        /// </summary>
        /// <value>
        /// The port.
        /// </value>
        public int Port { get; private set; }

        /// <summary>
        /// Gets the API key.
        /// </summary>
        /// <value>
        /// The API key.
        /// </value>
        public string ApiKey { get; private set; }

        /// <summary>
        /// Gets the URL base.
        /// </summary>
        /// <value>
        /// The URL base.
        /// </value>
        public string UrlBase { get; private set; }

        /// <summary>
        /// Gets a value indicating whether [use SSL].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [use SSL]; otherwise, <c>false</c>.
        /// </value>
        public bool UseSsl { get; private set; }

        /// <summary>
        /// Gets the API URL.
        /// </summary>
        /// <value>
        /// The API URL.
        /// </value>
        internal string ApiUrl { get; private set; }

        /// <summary>
        /// Gets or sets a value indicating whether [write debug].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [write debug]; otherwise, <c>false</c>.
        /// </value>
        public bool WriteDebug { get; set; }

        /// <summary>
        /// Calendar endpoint client
        /// </summary>
        public ICalendar Calendar { get; }

        /// <summary>
        /// Command endpoint client
        /// </summary>
        public ICommand Command { get; }

        /// <summary>
        /// Diskspace endpoint client
        /// </summary>
        public IDiskspace Diskspace { get; }

        /// <summary>
        /// Episode endpoint client
        /// </summary>
        public IEpisode Episode { get; }

        /// <summary>
        /// EpisodeFile endpoint client
        /// </summary>
        public IEpisodeFile EpisodeFile { get; }

        /// <summary>
        /// History endpoint client
        /// </summary>
        public IHistory History { get; }

        /// <summary>
        /// WnatedMissing endpoint client
        /// </summary>
        public IWantedMissing WantedMissing { get; }

        /// <summary>
        /// Queue endpoint client
        /// </summary>
        public IQueue Queue { get; }

        /// <summary>
        /// Parse endpoint client
        /// </summary>
        public IParse Parse { get; }

        /// <summary>
        /// Profile endpoint client
        /// </summary>
        public IProfile Profile { get; }

        /// <summary>
        /// Release endpoint client
        /// </summary>
        public IRelease Release { get; }

        /// <summary>
        /// ReleasePush endpoint client
        /// </summary>
        public IReleasePush ReleasePush { get; }

        /// <summary>
        /// RootFolder endpoint client
        /// </summary>
        public IRootfolder Rootfolder { get; }

        /// <summary>
        /// Series endpoint client
        /// </summary>
        public ISeries Series { get; }

        /// <summary>
        /// SeriesLookup endpoint client
        /// </summary>
        public ISeriesLookup SeriesLookup { get; }

        /// <summary>
        /// SystemStatus endpoint client
        /// </summary>
        public ISystemStatus SystemStatus { get; }

        /// <summary>
        /// SystemBackup endpoint client
        /// </summary>
        public ISystemBackup SystemBackup { get; }

        /// <summary>
        /// Log endpoint client
        /// </summary>
        public ILog Log { get; }

        /// <summary>
        /// Gets the GET response as a json formatted string
        /// </summary>
        /// <param name="endpointUrl">Endpoint URL</param>
        /// <returns>string</returns>
        internal async Task<string> GetJson(string endpointUrl)
        {
            Debug.WriteLine($"[SonarrSharp] [DEBUG] [SonarrClient.PostJson] Endpoint URL: '{endpointUrl}'");

            var response = string.Empty;

            using (_webClient = new WebClient { Headers = WebClientHelpers.GetWebHeaderCollection(ApiKey), Proxy = null })
            {
                try
                {
                    response = await _webClient.DownloadStringTaskAsync($"{ApiUrl}{endpointUrl}");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"[SonarrSharp] [ERROR] [SonarrClient.GetJson] Endpoint URL: '{endpointUrl}', {ex}");
                }
                finally
                {
                    if (WriteDebug)
                    {
                        Debug.WriteLine($"[SonarrSharp] [DEBUG] [SonarrClient.PostJson] Endpoint URL: '{endpointUrl}', response: {response}");
                        var webClientHeaders = _webClient.ResponseHeaders;
                        if (webClientHeaders != null)
                            for (int i = 0; i < webClientHeaders.Count; i++)
                                Debug.WriteLine($"[SonarrSharp] [DEBUG] [SonarrClient.GetJson] Response header: {webClientHeaders.GetKey(i)}={webClientHeaders.Get(i)}");
                    }
                }
            }

            if (!string.IsNullOrEmpty(response)) // Convert response to UTF8
                response = Encoding.UTF8.GetString(Encoding.Default.GetBytes(response));

            return response;
        }

        /// <summary>
        /// Gets the POST/PUT response as a json formatted string
        /// </summary>
        /// <param name="endpointUrl">Endpoint URL</param>
        /// <param name="data">Json formatted string</param>
        /// <param name="method">HTTP method, POST/PUT</param>
        /// <returns>string</returns>
        internal async Task<string> PostJson(string endpointUrl, string data, string method)
        {
            if (WriteDebug)
                Debug.WriteLine($"[SonarrSharp] [DEBUG] [SonarrClient.PostJson] {method}: Endpoint URL: '{endpointUrl}', data: '{data}'");

            var response = string.Empty;

            using (_webClient = new WebClient { Headers = WebClientHelpers.GetWebHeaderCollection(ApiKey), Proxy = null })
            {
                try
                {
                    response = await _webClient.UploadStringTaskAsync($"{ApiUrl}{endpointUrl}", method, data);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"[SonarrSharp] [ERROR] [SonarrClient.PostJson] {method}: Endpoint URL: '{endpointUrl}', data: '{data}', {ex}");
                }
                finally
                {
                    if (WriteDebug)
                    {
                        Debug.WriteLine($"[SonarrSharp] [DEBUG] [SonarrClient.PostJson] {method}: Endpoint URL: '{endpointUrl}', data: '{data}', response: {response}");
                        var webClientHeaders = _webClient.ResponseHeaders;
                        if (webClientHeaders != null)
                            for (int i = 0; i < webClientHeaders.Count; i++)
                                Debug.WriteLine($"[SonarrSharp] [DEBUG] [SonarrClient.GetJson] Response header: {webClientHeaders.GetKey(i)}={webClientHeaders.Get(i)}");
                    }
                }
            }

            if (!string.IsNullOrEmpty(response)) // Convert response to UTF8
                response = Encoding.UTF8.GetString(Encoding.Default.GetBytes(response));

            return response;
        }

        /// <summary>
        /// Send DELETE request to specified url
        /// </summary>
        /// <param name="endpointUrl">Endpoint URL</param>
        /// <returns>Nothing</returns>
        internal async Task Delete(string endpointUrl)
        {
            if (WriteDebug)
                Debug.WriteLine($"[SonarrSharp] [DEBUG] [SonarrClient.Delete] Endpoint URL: '{endpointUrl}'");

            using (var httpClient = new HttpClient { BaseAddress = new Uri(ApiUrl) })
            {
                httpClient.DefaultRequestHeaders.Add("X-Api-Key", ApiKey);
                httpClient.DefaultRequestHeaders.Add("Content-Type", "application/json");
                httpClient.DefaultRequestHeaders.Add("User-Agent", $"{Assembly.GetExecutingAssembly().GetName().Name.Replace(" ", ".")}.v{Assembly.GetExecutingAssembly().GetName().Version}");

                try
                {
                    await httpClient.DeleteAsync(endpointUrl);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"[SonarrSharp] [ERROR] [SonarrClient.Delete] Endpoint URL: '{endpointUrl}', {ex}");
                }
            }
        }
    }
}
