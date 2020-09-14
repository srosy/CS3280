using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public class BasePlusCommissionEmployee : CommissionEmployee
    {
        private decimal _baseSalary;
        public decimal BaseSalary
        {
            get { return _baseSalary; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("BaseSalary", "Base Salary can only be positive");
                _baseSalary = value;
            }
        }

        public BasePlusCommissionEmployee() { }

        public BasePlusCommissionEmployee(string fname, string lname, string ssn, decimal sales, decimal commission, decimal baseSalary)
            : base(fname, lname, ssn, sales, commission)
        {
            BaseSalary = baseSalary;
        }

        public BasePlusCommissionEmployee(decimal baseSalary) : base("FName", "LName", "$$N", 0, 0)
        {
            BaseSalary = baseSalary;
        }

        public decimal Earning()
        {
            return BaseSalary + base.Earning();
        }

        public void PrintInfo()
        {
            Console.WriteLine("\n***** Base + Commission Employee Info: *****");
            PrintCommonInfo();
            Console.WriteLine("Base Salary: " + BaseSalary);
            Console.WriteLine("Earning: " + Earning());
        }
    }
}
