using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using models;
using Newtonsoft.Json;

namespace devnull
{
    public class WebClient
    {
        public async void Walk(string direction)
        {
            var target = "move";
            var entityId = "e9accfc9-e01a-4af6-a727-dd3e856f7575";
            var sessionId = "b157cf63-628e-4868-9488-893e58664c67";

            var fuckmarcus =
                string.Format("/api/?target={0}&direction={1}&entityid={2}&sessionId={3}", target, direction, entityId, sessionId);

            await RunAsync(fuckmarcus);
        }

        public async void Pickup()
        {
            var target = "pickup";
            var entityId = "e9accfc9-e01a-4af6-a727-dd3e856f7575";
            var sessionId = "b157cf63-628e-4868-9488-893e58664c67";

            var fuckmarcus =
                string.Format("/api/?target={0}&&entityid={1}&sessionId={2}", target, entityId, sessionId);

            var result = await RunAsync(fuckmarcus);
        }

        public async Task<RootObject> Scan()
        {
            var target = "scan";
            var entityId = "e9accfc9-e01a-4af6-a727-dd3e856f7575";
            var sessionId = "b157cf63-628e-4868-9488-893e58664c67";

            var fuckmarcus =
                string.Format("/api/?target={0}&&entityid={1}&sessionId={2}", target, entityId, sessionId);

            var result = await RunAsync(fuckmarcus);

            var scanresult = JsonConvert.DeserializeObject<RootObject>(result);

            return scanresult;
        }


        public async Task<string> RunAsync(string request)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://callofthedeep.net");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xhtml+xml"));
                client.DefaultRequestHeaders.Add("User-Agent", " (linus.wijk@gmail.com)");

                try
                {
                    HttpResponseMessage responseMsg = await client.GetAsync(request);

                    if (responseMsg.IsSuccessStatusCode)
                    {
                        string result = await responseMsg.Content.ReadAsStringAsync();

                        return result;
                    }

                    return null;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw e;
                }
            }
        }
    }
}
