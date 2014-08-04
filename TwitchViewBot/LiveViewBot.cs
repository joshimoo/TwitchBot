using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;


namespace TwitchViewBot
{
    public class LiveViewBot
    {
        public async Task<string[]> GenerateViewLinksAsync(string channel, int amount = 300)
        {
            // NOTE: The Amount is fixed, we could use a regular array
            var viewLinks = new List<string>();
            TwitchClient client = new TwitchClient();

            for (int i = 0; i < amount; i++)
            {
                // Request Access Token
                // HACK: This is a quick and dirty, deserialization using the builtin DataContractJsonSerializer.
                string tokenUrl = String.Format("https://api.twitch.tv/api/channels/{0}/access_token.json", channel);
                string json = await client.MakeRequestAsync(tokenUrl);
                TwitchAccess access = ReadAs<TwitchAccess>(json);

                // Request Viewing Endpoint
                string viewerUrl = String.Format("http://usher.twitch.tv/select/{0}.json?allow_source=true&nauthsig={1}&private_code=null&type=any&nauth={2}&p=801601", channel, access.sig, access.token);
                string text = await client.MakeRequestAsync(viewerUrl);
                if (text.Contains("http://video"))
                {
                    // Get the different Stream Quality Sources, we want to make sure we have a XXX curve distribution for the added viewers. TODO: see if there is twitch stats on the distribution
                    var lines = text.Split('\n');
                    List<string> sources = lines.Where(line => line.Contains("http://video")).ToList();

                    // TODO: replace this with the appropriate distribution
                    viewLinks.Add(sources.Last());
                }
            }

            return viewLinks.ToArray();
        }

        private T ReadAs<T>(string json)
        {
            using (MemoryStream ms = new MemoryStream(Encoding.Default.GetBytes(json)))
            {
                var jsonSerializer = new DataContractJsonSerializer(typeof(T));
                return (T)jsonSerializer.ReadObject(ms);
            }
        }
    }
}
