using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Wek70.Exercise3
{
    public static class ExceptionsLists
    {

        public static void Run()
        {
            ExceptionLists();
        }

        private static void ExceptionLists()
        {
            try
            {
                List<int> numbers = UserInput();
                int sum = CalculateSum(numbers);
                double mean = CalculateAverage(numbers, sum);

                Console.WriteLine($"Sum : {sum}");
                Console.WriteLine($"Mean : {mean}");

            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Input string was not in a correct format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Arithmetic operation resulted in an overflow.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Attempted to divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
            
        }

        private static List<int> UserInput()
        {
            Console.WriteLine("Enter numbers (separated by space) : ");
            string input = Console.ReadLine();
            string[] numberSplits = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //string numberSplits = string.Join(' ', input);
            List<int> result = new List<int>();

            foreach (var numberSplit in numberSplits)
            {
                try
                {
                    int number = Convert.ToInt32(numberSplit);
                    result.Add(number);
                }
                catch (FormatException)
                {                  
                    throw;
                }
            }
            return result;
        }

        private static int CalculateSum(List<int> numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                try
                {
                    sum = checked(sum + number);
                    //checked is a keyword to see if the data type is not getting overflowed
                    //I could have probably used int.MaxValue and int.MinValue
                }
                catch(OverflowException)
                {
                    throw;
                }
            }
            return sum;
        }


        private static double CalculateAverage(List<int> numbers, int sum)
        {
            if(numbers.Count == 0)
            {
                throw new DivideByZeroException();
            }
            return (double)sum / numbers.Count;
        }


    }
}
