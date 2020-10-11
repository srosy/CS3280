using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Starting Recursive QuickSort ***");
            Console.WriteLine("Please enter the number of elements in the array: ");
            int numElements = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] unsortedArray = new int[numElements];
            Random random = new Random();
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                unsortedArray[i] = random.Next(0, 100000);
            }
            Console.WriteLine($"Unsorted Array[{numElements}]: [{string.Join(",", unsortedArray)}]");
            Console.WriteLine();

            Console.WriteLine($"QuickSorted Array: {string.Join(",", QuickSort.SortItQuickRecursively(unsortedArray, 0, unsortedArray.Length - 1))}");

            Console.ReadLine();
        }
    }
}
