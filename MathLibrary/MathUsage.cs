using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class MathUsage
    {
        public void UseMathLibraryMethods()
        {
            MathLibrary.Math math = new MathLibrary.Math();
            int sum = math.Add(2, 3);
            Console.WriteLine("Sum of 2 and 3 is: " + sum);
        }
    }
}
