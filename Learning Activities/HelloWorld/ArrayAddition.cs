using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class ArrayAddition
    {
        /// <summary>
        /// Length Specifices number of elements
        /// </summary>
        /// <param name="a"> Array indexing starts at 0</param>
        /// <returns> sum of array</returns>
        public int Sum(int[] a)
        {
            int sum = 0;
            for(int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }

    }
}
