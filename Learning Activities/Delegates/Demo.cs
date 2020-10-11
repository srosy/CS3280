using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Demo
    {
        public delegate int operation(int a, int b);
        public event operation operationFired;

        public int DemoMethod(operation op, int a, int b)
        {
            return op(a, b);
        }
    }
}
