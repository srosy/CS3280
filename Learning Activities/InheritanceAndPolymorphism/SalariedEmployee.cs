using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public class SalariedEmployee : Employee
    {
        private decimal _weeklySalary;
        public SalariedEmployee() : base()
        {
        }

        public SalariedEmployee(string fname, string lname, string ssn, decimal weeklySalary)
            : base(fname, lname, ssn)
        {
            WeeklySalary = weeklySalary;
        }

        public decimal WeeklySalary
        {
            get { return _weeklySalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Weekly salary cannot be negative");
                }
                _weeklySalary = value;
            }
        }

        public override decimal Earning() => WeeklySalary;

        public override string ToString() => base.ToString() + "Weekly Salary: " + WeeklySalary + "\nEarning: " + Earning();
        
    }
}
