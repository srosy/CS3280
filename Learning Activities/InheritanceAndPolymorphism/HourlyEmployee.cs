using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public class HourlyEmployee : Employee
    {
        private decimal _wages;
        private decimal _hours;

        public HourlyEmployee() : base()
        { }

        public HourlyEmployee(string fname, string lname, string ssn, decimal wages, decimal hours)
            : base(fname, lname, ssn)
        {
            Hours = hours;
            Wages = wages;
        }
        public decimal Wages
        {
            get { return _wages; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("wages cannot be negative");
                }
                _wages = value;
            }
        }

        public decimal Hours
        {
            get { return _hours; }
            set
            {
                if (value < 0 || value > 168)
                {
                    throw new ArgumentOutOfRangeException("Error in entering hours");
                }
                _hours = value;
            }
        }

        public override decimal Earning() => Hours * Wages;
        public override string ToString() => base.ToString() + "Hourly rate: " + Wages + $"\nHours: {Hours}" + "\nEarning: " + Earning();
    }
}
