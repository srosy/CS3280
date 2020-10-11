using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedInterface
{
    public abstract class Employee : IPayable
    {
        public string FirstName { get; set; }
        public string LastName { get; }
        public string SSN { get; }

        public Employee() { }

        public Employee(string fname, string lname, string ssn)
        {
            FirstName = fname;
            LastName = lname;
            SSN = ssn;
        }

        public override string ToString() => $"Name: {FirstName} {LastName}\nSSN:{SSN}\n";
        public abstract decimal Earning();
        public decimal GetPaymentAmount() => Earning();
    }
}
