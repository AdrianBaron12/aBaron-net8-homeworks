using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
namespace Week11HW.Asyncs
{/// <summary>
/// Write a C# program that uses the async and await keywords to fetch multiple URLs concurrently, and then prints out the content of the first URL to complete.
/// </summary>
    public static class Exercise4
    {
        //public static void Run()
        //{
        //    Exercise();
        //}
        public static async Task Exercise()
        {
            List<string> URL = new List<string>
            {
                "https://google.com",
                "https://microsoft.com",
                "https://altex.ro"
            };
            string firstComplete = await FirstCompletedAsync(URL);
            Console.WriteLine(firstComplete);
            //await Console.Out.WriteLineAsync(firstComplete);
        }

        private static async Task<string> FirstCompletedAsync(List<string> URLs)
        {
           using var httpClient = new HttpClient();
            var tasks = URLs.ConvertAll(url => FetchAsync(httpClient, url));
            var completedTask = await Task.WhenAny(tasks);
            return await completedTask;
        }

        static async Task<string> FetchAsync(HttpClient httpClient, string url)
        {
            try
            {
                var response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();

            }
            //catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
            //{
            //    Console.WriteLine("URL not found");
            //    return null;
            //}
            catch(HttpRequestException ex)
            {
                Console.WriteLine("Failed to fetch url");
                return null;
            }

            } 
        }

    }

