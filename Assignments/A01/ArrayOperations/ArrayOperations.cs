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
            if (intArray.Length <= 0)
                throw new Exception("Int array must contain at least one element!");

            int max = intArray.First();
            intArray.ToList().ForEach(i =>
            {
                if (max < i)
                    max = i;
            });

            return max;
            //return intArray.Max(); // what I would normally do, but I think you want the work
        }

        /// <summary>
        /// Returns the min int from an int sequence in an array.
        /// </summary>
        /// <param name="intArray"></param>
        /// <returns> int </returns>
        public static int Min(int[] intArray)
        {
            if (intArray.Length <= 0)
                throw new Exception("Int array must contain at least one element!");

            int min = intArray.First();
            intArray.ToList().ForEach(i =>
            {
                if (min > i)
                    min = i;
            });

            return min;
            //return intArray.Min(); // what I would normally do, but I think you want the work
        }

        /// <summary>
        /// Returns the average int from an int sequence in an array.
        /// </summary>
        /// <param name="intArray"></param>
        /// <returns> int </returns>
        public static double Avg(int[] intArray)
        {
            if (intArray.Length <= 0)
                throw new Exception("Int array must contain at least one element!");

            double avg = 0;
            intArray.ToList().ForEach(i =>
            {
                avg += i;
            });

            return Math.Round(avg / intArray.Length, 3);
            //return intArray.Average(); // what I would normally do, but I think you want the work
        }
    }
}
