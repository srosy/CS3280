using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceVsValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a;
            Console.WriteLine($"a is: {a}, b is: {b}");
            a++;
            Console.WriteLine($"a is: {a}, b is: {b}");

            Car c = new Car();
            c._make = "Toyota";
            c._model = "Camry";
            Car anotherCar = c;

            Console.WriteLine($"Car c: {c._make} {c._model}");
            Console.WriteLine($"Car anotherCar: {anotherCar._make} {anotherCar._model}");

            c._make = "Nissan";
            c._model = "Altima";

            Console.WriteLine($"Car c: {c._make} {c._model}");
            Console.WriteLine($"Car anotherCar: {anotherCar._make} {anotherCar._model}");

            Console.ReadLine();
        }
    }
}
