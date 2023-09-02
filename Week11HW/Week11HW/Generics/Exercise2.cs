using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11HW.Generics
{
    /// <summary>
    /// Create a generic method that takes in a list of any type
    /// and applies a specific action to each element using a lambda expression.
    /// </summary>
    public static class Exercise2
    {
        public static void ApplyAction<T>(this List<T> input,Action<T> action)
        {
            foreach (T item in input)
            {
                action(item);
            }
        }
    }
}
