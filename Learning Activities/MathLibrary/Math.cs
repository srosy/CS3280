using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class Math
    {
        public int Add(int first, int second)
        {
            return first + second;
        }

        internal int Subtract(int first, int second)
        {
            return first - second;
        }

        internal int Multiply(int first, int second)
        {
            return first * second;
        }

        internal int Divide(int first, int second)
        {
            return first / second;
        }
    }
}
