using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wek70.Exercise2
{
    public class BlankNameException : Exception
    {
        public BlankNameException(string? message) : base(message)
        {
            
        }
    }
}
