using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace TwitchViewBot
{
    [DataContract]
    public class TwitchAccess
    {
        [DataMember]
        public string token { get; set; }
        [DataMember]
        public string sig { get; set; }
        [DataMember]
        public bool mobile_restricted { get; set; }
    }

    public class TwitchClient
    {
        // Async vs Sync Threading: http://stackoverflow.com/questions/16194054/is-async-httpclient-from-net-4-5-a-bad-choice-for-intensive-load-applications
        public HttpClient Client { get; set; }
        public HttpClientHandler Handler { get; set; }
        public CookieContainer Cookies
        {
            get { return Handler.CookieContainer; }
            set { Handler.CookieContainer = value; }
        }

        public TwitchClient() { Initalize(); }

        private void Initalize()
        {
            // Limit to maximum of 256 Connections
            ServicePointManager.DefaultConnectionLimit = 256;

            //Trust all certificates
            ServicePointManager.ServerCertificateValidationCallback = ((sender, certificate, chain, sslPolicyErrors) => true);

            // TODO: Add Proxy Support
            Handler = new HttpClientHandler
            {
                AllowAutoRedirect = true,
                UseCookies = true,
                CookieContainer = new CookieContainer(),
                UseDefaultCredentials = false,
                Proxy = null,
                UseProxy = false
            };

            // Create the HTTP Client
            Client = new HttpClient(Handler);
            Client.DefaultRequestHeaders.Clear();
            Client.DefaultRequestHeaders.CacheControl = new CacheControlHeaderValue { MaxAge = TimeSpan.FromSeconds(0) };
            Client.DefaultRequestHeaders.Accept.ParseAdd("text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
            Client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/32.0.1700.107 Safari/537.36");
        }

        public async Task<string> MakeRequestAsync(string url)
        {
            HttpResponseMessage response = await Client.GetAsync(url);
            if (response.IsSuccessStatusCode) { return await response.Content.ReadAsStringAsync(); }
            else { return response.StatusCode.ToString(); }
        }
    }
}