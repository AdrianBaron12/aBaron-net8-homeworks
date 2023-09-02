using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.Encodings;
namespace Week11HW.Asyncs
{
    public static class Exercise7
    {
        public static async Task Run()
        {
            string path = "file.txt";
            string Content = "😎😎😎😎😎😎😎zzzz";
            //byte[] bytes = Encoding.UTF8.GetBytes(Content);
            //Content = Encoding.UTF8.GetString(bytes);
            await WriteStringFileAsync(path, Content);
        }

        public static async Task WriteStringFileAsync(string path, string content)
        {
            try
            {
                using(StreamWriter write = new StreamWriter(path))
                {
                    Console.OutputEncoding=System.Text.Encoding.UTF8; //I tried to make the 😎 appear
                     System.Console.Write(content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
            
        }
    }
}
