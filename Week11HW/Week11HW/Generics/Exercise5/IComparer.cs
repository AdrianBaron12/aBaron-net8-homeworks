using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11HW.Generics.Exercise5
{
    public interface IComparer<T>
    {
        int Compare(T x, T y);
    }
}
