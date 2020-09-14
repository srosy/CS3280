using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public class CommissionEmployee
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected string SSN { get; }


        public decimal GrossSales
        {
            get { return _grossSales; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("GrossSales", "Gross sales can only be positive");
                _grossSales = value;
            }
        }
        private decimal _grossSales; // should be positive

        public decimal CommissionRate
        {
            get { return _commissionRate; }
            set
            {
                if (value < 0.0m || value > 1.0m)
                    throw new ArgumentOutOfRangeException("CommissionRate", "Commission Rate should be betweeen 0.0 and 1.0");
                _commissionRate = value;
            }
        }
        private decimal _commissionRate; // should be positive and between 0.0 to 1.0


        public CommissionEmployee() { }

        public CommissionEmployee(string fname, string lname, string ssn, decimal sales, decimal commission)
        {
            FirstName = fname;
            LastName = lname;
            SSN = ssn;
            GrossSales = sales;
            CommissionRate = commission;
        }

        public decimal Earning()
        {
            return GrossSales * CommissionRate;

        }

        public void PrintInfo()
        {
            Console.WriteLine("\n***** Commission Employee Info: *****");
            PrintCommonInfo();
            Console.WriteLine("Earning: " + Earning());
        }

        protected void PrintCommonInfo()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
            Console.WriteLine("SSN: " + SSN);
            Console.WriteLine("Gross Sales: " + GrossSales);
            Console.WriteLine("Commission Rate: " + CommissionRate);
        }
    }
}
