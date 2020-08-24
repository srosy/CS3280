using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructure
{
    public class Max
    {
        public int MaxOf2Numbers(int firstNum, int secondNum)
        {
            if (firstNum > secondNum)
                return firstNum;
            else
                return secondNum;
        }

        public int MaxOf3Numbers(int first, int second, int third)
        {
            if (first >= second)
            {
                if (first >= third)
                    return first;
                else
                    return third;
            }
            else
            {
                if (second >= third)
                    return second;
                else
                    return third;
            }
        }
    }
}
