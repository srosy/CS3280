using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MathLibrary.Math math = new MathLibrary.Math();
            int sum = math.Add(2, 3);
            Console.WriteLine("The answer of 2 + 3 is: " + sum);

            Console.ReadLine();
        }
    }
}
