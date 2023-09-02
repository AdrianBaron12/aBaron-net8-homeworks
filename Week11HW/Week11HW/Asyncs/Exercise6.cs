using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11HW.Asyncs
{
    public static class Exercise6
    {
        public static async Task Run()
        {
            string url = await GetHttpAsync("https://www.google.com");

            if(url == null)
            {
                await Console.Out.WriteLineAsync("No data");
            }
            else
            {
                await Console.Out.WriteLineAsync(url);
            }
        }


        public static async Task<string> GetHttpAsync(string url)
        {
            {
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await client.GetAsync(url);
                        response.EnsureSuccessStatusCode();
                        return await response.Content.ReadAsStringAsync();
                    }
                    catch (HttpRequestException ex)
                    {
                        await Console.Out.WriteLineAsync($"Http request error {ex.Message}");
                        return null;
                    }
                }
            }
        }
    }
}
