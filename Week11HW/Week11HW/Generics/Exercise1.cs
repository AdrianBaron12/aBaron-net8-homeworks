using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Week11HW.Generics
{

    /// <summary>
    /// Create a generic method that takes in a list of any type
    /// and reverses the order of the elements.
    /// </summary>
    public static class Exercise1
    {


      
        public static void MyReverse<T>(List<T> input)
        {

           for(int start = 0, end = input.Count-1; start < end; start++,end--)
            {
                MySwap(input, start, end);
            }
        }

        private static void MySwap<T>(List<T> items, int a, int b)
        {
            var temp = items[a];
            items[a] = items[b];
            items[b] = temp;
        }

       
    }
}
