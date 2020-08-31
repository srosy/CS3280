using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByReferenceVsValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int originalInt = 10;
            Car originalCar = new Car();
            originalCar._make = "Toyota";
            originalCar._model = "Camry";
            originalCar._price = 23000m;
            originalCar._yearBuilt = 2019;

            Console.WriteLine($"Original Int Value: {originalInt}");
            Console.WriteLine($"Original Car Value: {originalCar._make} {originalCar._model} {originalCar._price} {originalCar._yearBuilt}");

            PassByReferenceValue passByReferenceValue = new PassByReferenceValue();
            passByReferenceValue.ExampleMethod(originalInt, originalCar);

            Console.WriteLine("After Calling ExampleMethod: ");
            Console.WriteLine($"Original Int Value: {originalInt}");
            Console.WriteLine($"Original Car Value: {originalCar._make} {originalCar._model} {originalCar._price} {originalCar._yearBuilt}");

            int anotherInt = 10;
            Console.WriteLine($"another Int Original Value: {anotherInt}");
            passByReferenceValue.ChangeIntValueByPassingItAsReference(ref anotherInt);
            Console.WriteLine($"another Int Change Value: {anotherInt}");

            Console.ReadLine();
        }
    }
}
