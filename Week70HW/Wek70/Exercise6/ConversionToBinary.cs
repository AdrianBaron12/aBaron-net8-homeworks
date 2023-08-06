using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wek70.Exercise6
{
    public static class ConversionToBinary
    {
        public static void Run()
        {
            ToBinaryStrings();
        }

        private static void ToBinaryStrings()
        {
            Console.WriteLine("Introduce a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            string binary = num.ToBinaryString();
            Console.WriteLine($"Binary representation of {num} is {binary}");
        }

        private static string ToBinaryString(this int n)
        {
            if (n == 0)
                return "0";

            int[] binaryNum = new int[31];

            int i = 0;
            while(n > 0)
            {
                binaryNum[i] = n % 2;
                n /= 2;
                i++;
            }

            string binaryString = null;
            for(int j=i-1; j >= 0; j--)
            {
                binaryString += binaryNum[j];
            }
            return binaryString;
        }


    }
}
