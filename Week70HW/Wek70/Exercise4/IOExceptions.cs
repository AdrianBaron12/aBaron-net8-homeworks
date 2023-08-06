using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Wek70.Exercise4
{
    public static class IOExceptions
    {
        public static void Run()
        {
            IOEx();
        }

        private static void IOEx()
        {
            Console.WriteLine("File name is : ");
            string fileName = Console.ReadLine();

            try
            {
                if (File.Exists(fileName))
                {
                    string fileContent = File.ReadAllText(fileName);
                    if (string.IsNullOrEmpty(fileContent))
                    {
                        Console.WriteLine("File is empty");
                        WriteFile(fileName);

                    }
                    else
                    {
                        Console.WriteLine($"File has the contents ");
                        Console.WriteLine(fileContent);
                    }
                }
                else
                {
                    Console.WriteLine("File does not exist");
                    WriteFile(fileName);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"An IO error occured {e.Message}");
            }
        }

        private static void WriteFile(string fileName)
        {
            try
            {
                Console.WriteLine("Enter some text to write in the file:");
                string fileContent = Console.ReadLine();
                File.WriteAllText(fileName, fileContent);
                Console.WriteLine($"The file has the contents: ");
                Console.WriteLine(fileContent);
            }
            catch (IOException e)
            {
                Console.WriteLine($"An IO error occured {e.Message}");
            }
        }
    }
}
