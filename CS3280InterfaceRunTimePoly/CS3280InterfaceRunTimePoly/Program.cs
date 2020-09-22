using System;

namespace CS3280InterfaceRunTimePoly
{
    class Program
    {
        static void Main(string[] args)
        {

            // Use interface to acheive run time polymorphism. 
            IComparable ic1;
            IComparable ic2;
            int compResult;

            Car c1 = new Car("Toyota", "Corolla", "12345678", "Red");
            Car c2 = new Car("Toyota", "Camry", "23456789", "Beige");
            ic1 = c1;
            ic2 = c2;

            compResult = ic1.CompareTo(ic2);

            Person p1 = new Person("Spencer", "Rosenvall", "111-11-1111");
            Person p2 = new Person("Gavin", "Rosenvall", "111-11-1211");

            ic1 = c1;
            ic2 = c2;

            compResult = ic1.CompareTo(ic2);

            System.Console.ReadLine();
        }
    }
}
