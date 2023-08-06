using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wek70.Exercise8
{
    public static class OriginalSquareList
    {
        public static void Run()
        {
            OriginalAndSquare();
        }

        private static void OriginalAndSquare()
        {
            List<int> num = new List<int> { 1,2,3,4,5,6};

            Console.WriteLine("Original List : ");
            foreach(int i in num)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();

            List<int> square = num.Select(x => x*x).ToList();

            Console.WriteLine("Squares of the list above : ");
            foreach(int i in square)
            {
                Console.Write($"{i} ");
            }
        }

    }
}
