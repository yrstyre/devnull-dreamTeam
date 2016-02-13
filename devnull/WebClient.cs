using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace devnull
{
    public class WebClient
    {
        public void Do(string target, string direction, string entityId, string sessionId)
        {
            target = "move";
            direction = "r";
            entityId = "e9accfc9-e01a-4af6-a727-dd3e856f7575";
            sessionId = "5da97370-d4cb-4ee8-9c45-6bfdfedf432e";

            var fuckmarcus =
                string.Format("/api/?target={0}&direction={1}&entityid={2}&sessionId={3}", target, direction, entityId, sessionId);

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
