using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        // a delegate is a type safe function pointer
        delegate int operation(int a, int b);
        static event operation operationFired;

        static void Main(string[] args)
        {
            // Delegates...
            MathOperations m = new MathOperations();
            //operation op = m.Add;
            //operation op1 = new operation(m.Add);
            //Console.WriteLine(op(3, 4));
            //op = m.Subtract;
            //Console.WriteLine(op(3, 4));

            //// errs out because of type-safe violation
            ////op = m.Square;

            //Demo demo = new Demo();
            //Demo.operation op1 = new Demo.operation(m.Add);
            //var ans = demo.DemoMethod(op1, 3, 4);
            //Console.WriteLine(ans);

            // Events...
            //create delegate and make it point to a method
            operation op = new operation(m.Add);
            //op += m.Subtract; // += is a way to add another method for the delegate to point at
            operationFired += op; // associate an event with the delegate
            var answer = operationFired.Invoke(3, 4); // fire/invoke the event
            Console.WriteLine(answer);

            Console.ReadLine();
        }
    }
}
