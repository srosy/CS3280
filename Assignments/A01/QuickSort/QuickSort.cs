using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public static class QuickSort
    {
        public static int[] SortItQuickRecursively(int[] intArray, int left, int right)
        {
            if (left >= right)
                return intArray;

            int pivot = intArray[(left + right) / 2];
            int index = Partition(intArray, left, right, pivot);
            SortItQuickRecursively(intArray, left, index - 1);
            SortItQuickRecursively(intArray, index, right);

            return intArray;
        }

        public static int Partition(int[] intArray, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while (intArray[left] < pivot) left++; // find next left element to swap
                while (intArray[right] > pivot) right--; // find next right element to swap

                if (left <= right)
                {
                    SwapElements(intArray, left, right);
                    left++;
                    right--;
                }
            }
            return left; // partition point
        }

        private static void SwapElements(int[] intArray, int left, int right)
        {
            int temp = intArray[right];
            intArray[right] = intArray[left];
            intArray[left] = temp;
        }
    }
}
