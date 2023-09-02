using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11HW.Generics.Exercise5
{
    public  class Exercise5<T>: IComparer<T>
    {

        public  int Compare(T first, T second)
        {
            if (first == null && second == null)
                return 0;
            else
                if (first == null)
                return -1;
            else
                if (second == null)
                return 1;
            else
            {
              if(typeof(T)==typeof(string) && first.GetType() == typeof(string))
                {
                    return CompareStrings(first.ToString(), second.ToString());
                }
              //else if(typeof(T).GetType()) // 😕 i got stuck here
              //  {
              //      return CompareCollections(first as ICollection<T>, second as ICollection<T>)
              //  }
                else
                    throw new ArgumentException("The inputs are not strings or collections");
            }
        }

        private int CompareStrings(string firstString, string secondString)
        {
            return firstString.Length.CompareTo(secondString.Length);
        }

        private int CompareCollections(ICollection<T> firstCollection, ICollection<T> secondCollection)
        {
            return firstCollection.Count.CompareTo(secondCollection.Count);
        }
    }
}
