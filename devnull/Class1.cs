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
        // TODO: remake this and parser to take 100? products at the time (rps 30/burst 100) wait 3.33s
        public async Task<string> RunAsync(string request)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://callofthedeep.net/api/?target=move&direction=r&entityid=&sessionId=4b4125a2-a3c9-4cc9-9853-b84abd997b4a");
                client.DefaultRequestHeaders.Accept.Clear();
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xhtml+xml"));
                //client.DefaultRequestHeaders.Add("User-Agent", " (linus.wijk@gmail.com)");

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
