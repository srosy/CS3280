using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructure
{
    /// <summary>
    /// Iterative Search
    /// Binary Search in both ways, normal way and recursive way
    /// Iterative Search - 7,5,6,8,2
    /// </summary>
    public class Search
    {
        public int IterativeSearch(int[] intArray, int key)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] == key)
                    return i;
            }
            return -1;
        }

        // binary search: requires a sorted array
        // 1, 3, 4, 5, 6, 7, 10
        // key = 4
        public int BinarySearchIterative(int[] intArray, int key)
        {
            int min = 0;
            int max = intArray.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == intArray[mid])
                    return mid;
                else if (key < intArray[mid])
                    max = mid - 1;
                else
                    min = mid + 1;
            }

            return -1;
        }

        public int BinarySearchRecursive(int[] intArray, int key, int min, int max)
        {
            if (min > max)
                return -1;
            else
            {
                int mid = (min + max) / 2;
                if (key == intArray[mid])
                    return mid;
                else if (key < intArray[mid])
                    return BinarySearchRecursive(intArray, key, min, mid - 1);
                else
                    return BinarySearchRecursive(intArray, key, mid + 1, max);
            }
        }

    }
}
