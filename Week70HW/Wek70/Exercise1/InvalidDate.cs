using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Wek70.Exercise1
{
    public static class InvalidDate
    {

        public static void Run()
        {
            Validation();
        }


        public static void Validation()
        {
            try
            {
                string dateInput = GetUserInput("Enter your date (yyyy-mm-dd) : ");
                if (CheckDateForFuture(dateInput))
                {
                    Console.WriteLine("Date is valid and in future");
                }             
            }
            catch (InvalidDateException ex)
            {
                Console.WriteLine($"Invalid date: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occured {ex.Message}");
            }
        }

        private static string GetUserInput(string input)
        {
            Console.WriteLine(input);
            return Console.ReadLine();
        }

        //La functia CheckDateForFuture am folosit stackoverflow pentru ca
        //nu am stiut cum sa fac sa pot transforma string in datetime

        private static bool CheckDateForFuture(string dateInput)
        {
            DateTime today = DateTime.Today;

            if (DateTime.TryParse(dateInput, out DateTime inputDate))
            {
                if (inputDate.CompareTo(today) < 0)
                {
                    throw new InvalidDateException("Date is in the past");
                }
                return true;
            }
            else
            {
                throw new InvalidDateException("Invalid date format");
            }
        }

    }
}
