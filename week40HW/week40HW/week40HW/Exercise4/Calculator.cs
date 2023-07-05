using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Week40.Calculator1
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int Divide(int x, int y)
        {
            try
            {
                return x / y;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        public double Power(double x, double y)
        {
            return Math.Pow(x, y);
        }

        public double SquareRoot(double x)
        {
            return Math.Sqrt(x);
        }



    }
}
