using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            CommissionEmployee commissionEmployee = new CommissionEmployee("Spencer", "Rosenvall", "111-55-9999", 10000m, 0.50m);
            BasePlusCommissionEmployee basePlusCommissionEmployee
                = new BasePlusCommissionEmployee("Gavin", "Rosenvall", "222-54-8975", 15245m, 0.25m, 800m);

            // Commission Employee Info
            Console.WriteLine("Commission Employee Info: ");
            Console.WriteLine("Gross Sales: " + commissionEmployee.GrossSales);
            //Console.WriteLine("SSN: " + commissionEmployee.SSN);
            Console.WriteLine("Earning: " + commissionEmployee.Earning());

            // Base + Commission Employee Info
            Console.WriteLine("\nBase + Commission Employee Info: ");
            Console.WriteLine("Gross Sales: " + basePlusCommissionEmployee.GrossSales);
            //Console.WriteLine("SSN: " + basePlusCommissionEmployee.SSN);
            Console.WriteLine("Earning: " + basePlusCommissionEmployee.Earning());

            commissionEmployee.PrintInfo();
            basePlusCommissionEmployee.PrintInfo();

            Console.ReadLine();
        }
    }
}
