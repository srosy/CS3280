using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Math math = new Math();

            int sumAnswer = math.Sum(2, 3);
            Console.WriteLine($"The sum is: {sumAnswer}");

            int subtractAnswer = math.Subtract(5, 2);
            Console.WriteLine($"The difference is: {subtractAnswer}");

            Console.WriteLine("Starting Array Addition Verification");
            int[] a = new int[3] { 10, 20, 30 };
            Console.WriteLine($"The sum of array is: {new ArrayAddition().Sum(a)}");

            Console.ReadLine();
        }
    }
}
