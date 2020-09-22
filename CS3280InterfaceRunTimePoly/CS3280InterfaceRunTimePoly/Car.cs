using System;
using System.Collections.Generic;
using System.Text;

namespace CS3280InterfaceRunTimePoly
{
    public class Car : IComparable
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }

        public string Color { get; set; }

        public Car() { }

        public Car(string make, string model, string vin, string color)
        {
            Make = make;
            Model = model;
            VIN = vin;
            Color = color;
        }

        public override string ToString()
        {
            return "*****" + Make + " " + Model + " " + Color + " " + VIN;
        }
        public int CompareTo(object obj)
        {
            if (obj is Car)
            {
                Car c = (Car)obj;

                int firstComparision = string.Compare(this.Make, c.Make);

                if (firstComparision == 0)
                {
                    int secondComparision = string.Compare(this.Model, c.Model);
                    return secondComparision;
                }
                else
                {
                    return firstComparision;
                }

            }

            else
            {
                throw new ArgumentException("Comparision requires a Car object");
            }
        }
    }
}
