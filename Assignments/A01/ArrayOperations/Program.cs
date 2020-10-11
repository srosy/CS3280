using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Starting ArrayOperations ***");

            Console.WriteLine("Please input the number of elements for the array: ");
            int numArrayElements = int.Parse(Console.ReadLine());
            int[] intArray = new int[numArrayElements];
            Console.WriteLine();

            Random random = new Random();
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = random.Next(0, 100000);
            }
            Console.WriteLine($"Generated random int[{numArrayElements}]: [{string.Join(",", intArray)}]");
            Console.WriteLine();

            Console.WriteLine($"Max in array: {ArrayOperations.Max(intArray)}");
            Console.WriteLine($"Min in array: {ArrayOperations.Min(intArray)}");
            Console.WriteLine($"Average in array: {ArrayOperations.Avg(intArray)}");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
