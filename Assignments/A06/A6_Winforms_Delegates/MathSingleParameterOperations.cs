using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6_Winforms_Delegates
{
    public static class MathSingleParameterOperations
    {
        public static double Square(double num) => num * num;
        public static double SquareRoot(double num) => Math.Sqrt(num);
        public static double Cube(double num) => Math.Pow(num, 3);
    }
}
