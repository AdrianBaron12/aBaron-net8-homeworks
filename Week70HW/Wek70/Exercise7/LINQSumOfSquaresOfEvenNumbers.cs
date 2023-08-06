using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wek70.Exercise7
{
    public static class LINQSumOfSquaresOfEvenNumbers
    {
        public static void Run()
        {
            SumInLINQ();
        }

        private static void SumInLINQ()
        {
            List<int> list = new List<int> { 1,2,3,4,5,6,7,8};
            
            int sum = list.Where(x=>x%2==0)
                           .Sum(x=>x*x);

            Console.WriteLine($"Sum of square of even numbers is : {sum} ");
        }
    }
}
