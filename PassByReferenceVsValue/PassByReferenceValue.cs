using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByReferenceVsValue
{
    public class PassByReferenceValue
    {
        public void ExampleMethod(int intValue, Car car)
        {
            // intValue = originalInt, only value of the variable wil be copied and not hte address.
            // car = originalCar, the reference will be copied. Car and originalCar will point to the same memory location or same object.
            intValue++; //increase the value of int

            // change the value of car make, model, and price
            car._make = "Nissan";
            car._model = "Altima";
            car._price = 22000m;
        }

        public void ChangeIntValueByPassingItAsReference(ref int intValue)
        {
            intValue++;
        }
    }
}
