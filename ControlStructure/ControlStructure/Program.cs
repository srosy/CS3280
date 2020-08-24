using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] intArray;
            //Console.WriteLine("Enter an integer value: ");
            //string strUserIntInput = Console.ReadLine();
            //int intUserInput = int.Parse(strUserIntInput);

            //intArray = new int[intUserInput];
            //Random random = new Random();

            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    intArray[i] = random.Next(0, 10000);
            //}

            //int firstNumber = random.Next(0, 10000);
            //int secondNumber = random.Next(0, 10000);
            //int ans = random.Next(0, 10000);
            //Console.WriteLine(ans);

            // max of two numbers
            //Console.WriteLine("*** Starting Max of two numbers:");

            Random random = new Random();
            //int firstNumber = random.Next(0, 10000);
            //int secondNumber = random.Next(0, 10000);

            //Max max = new Max();
            //int maxNumber = max.MaxOf2Numbers(firstNumber, secondNumber);
            //Console.WriteLine($"First Number: {firstNumber}");
            //Console.WriteLine($"Second Number: {secondNumber}");
            //Console.WriteLine($"Maximum of two numbers: {maxNumber}");

            //// max of three numbers
            //Console.WriteLine("*** Starging Max of three numbers:");
            //int thirdNumber = random.Next(0, 10000);
            //Console.WriteLine($"First Number: {firstNumber}");
            //Console.WriteLine($"Second Number: {secondNumber}");
            //Console.WriteLine($"Third Number: {thirdNumber}");

            //maxNumber = max.MaxOf3Numbers(firstNumber, secondNumber, thirdNumber);
            //Console.WriteLine($"Maximum of three numbers: {maxNumber}");

            // Iterating binary search
            Console.WriteLine("*** Starting iterating binary search:");
            Console.WriteLine("Enter the number of elements in the array: ");
            string strNumElements = Console.ReadLine();
            int numElements = int.Parse(strNumElements);

            int[] iterativeSearchArray = new int[numElements];
            for(int i = 0; i < numElements; i++)
            {
                iterativeSearchArray[i] = random.Next(0, 10000);
            }

            Console.WriteLine("The generated array is: ");
            for(int i = 0; i < iterativeSearchArray.Length; i++)
            {
                Console.WriteLine(iterativeSearchArray[i]);
            }

            Console.WriteLine("Enter the key element: ");
            int key = int.Parse(Console.ReadLine());

            Search search = new Search();
            int indexOfKey = search.IterativeSearch(iterativeSearchArray, key);
            Console.WriteLine("IndexOfKey: " + indexOfKey);


            // Recursive binary search
            Console.WriteLine("*** Starting recursive binary search:");
            Console.WriteLine("Enter the number of elements for recursive binary search: ");
            int numElementsRecSearch = int.Parse(Console.ReadLine());
            int[] intRecBinarySearchArray = new int[numElementsRecSearch];
            // I need to create a sorted array
            for(int i = 0; i < intRecBinarySearchArray.Length; i++)
            {
                intRecBinarySearchArray[i] = 2 * i;
            }

            Console.WriteLine("The recursive search array elements are: ");
            for (int i = 0; i < intRecBinarySearchArray.Length; i++)
            {
                Console.WriteLine(intRecBinarySearchArray[i]);
            }

            Console.WriteLine("Enter the key for recursive binary search: ");
            int keyForBinarySearch = int.Parse(Console.ReadLine());

            int indexForBinaryRecSearch = search.BinarySearchRecursive(intRecBinarySearchArray, keyForBinarySearch, 0, intRecBinarySearchArray.Length - 1);
            Console.WriteLine("Index of Binary Search Recursive is: " + indexForBinaryRecSearch);

            Console.ReadLine();
        }
    }
}
