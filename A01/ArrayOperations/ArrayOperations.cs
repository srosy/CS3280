using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperations
{
    public static class ArrayOperations
    {
        /// <summary>
        /// Returns the max int from an int sequence in an array.
        /// </summary>
        /// <param name="intArray"></param>
        /// <returns> int </returns>
        public static int Max(int[] intArray)
        {
            return intArray.Max();
        }

        /// <summary>
        /// Returns the min int from an int sequence in an array.
        /// </summary>
        /// <param name="intArray"></param>
        /// <returns> int </returns>
        public static int Min(int[] intArray)
        {
            return intArray.Min();
        }

        /// <summary>
        /// Returns the average int from an int sequence in an array.
        /// </summary>
        /// <param name="intArray"></param>
        /// <returns> int </returns>
        public static double Avg(int[] intArray)
        {
            return intArray.Average();
        }
    }
}
