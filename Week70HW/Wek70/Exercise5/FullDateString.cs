using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wek70.Exercise5
{
    public static class FullDateString
    {
        public static void Run()
        {
            FullDateStrings();
        }

        private static void FullDateStrings()
        {
            DateTime now = DateTime.Now;
            string fullDateFormat = now.ToFullDateString();
            Console.WriteLine($"Formated date & time : {fullDateFormat}");
        }

        private static string ToFullDateString(this  DateTime date)
        {
            return date.ToString("MM/dd/yyyy HH:mm:ss");
        }

    }
}
