using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Wek70.Exercise2
{
    public static class BlankName
    {
        public static void Run()
        {
            WriteNames();
        }

        private static void BlankNameCheck(List<string> name)
        {
            foreach (string s in name)
            {
                if (string.IsNullOrWhiteSpace(s))
                {
                    throw new BlankNameException("There cannot be blank names");
                }
            }
        }

        private static List<string> ReadNames()
        {
            List<string> names = new List<string>();
            do
            {
                string name = Console.ReadLine();
                if (!(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(name)))
                {
                    names.Add(name);
                }
                else
                {
                    break;
                }
            } while (true);
            return names;
        }

        private static void WriteNames()
        {
            try
            {
                List<string> listOfNames = ReadNames();
                BlankNameCheck(listOfNames);
                Console.WriteLine("Names are valid");
            }
            catch(BlankNameException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        
    }
}
