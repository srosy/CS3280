using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            SalariedEmployee salariedEmployee = new SalariedEmployee("John", "Smith", "111-11-1111", 800m);
            HourlyEmployee hourlyEmployee = new HourlyEmployee("Karen", "Price", "222-22-2222", 22.5m, 40);
            CommissionEmployee commissionEmployee = new CommissionEmployee("Sue", "Jones", "333-33-3333", 1000m, 0.10m);
            BasePlusCommissionEmployee basePlusCommissionEmployee = new BasePlusCommissionEmployee("Bob", "Lewis", "444-44-4444", 1000m, 0.25m, 12m);
            Invoice invoice = new Invoice("Part1", "Part 1 Desc", 10, 4.99m);

            // without using polymorphism, print all payments
            //Console.WriteLine($"Salaried Employee Payment: {salariedEmployee.GetPaymentAmount()}");
            //Console.WriteLine($"Hourly Employee Payment: {hourlyEmployee.GetPaymentAmount()}");
            //Console.WriteLine($"Commission Employee Payment: {commissionEmployee.GetPaymentAmount()}");
            //Console.WriteLine($"Base+Commission Employee Payment: {basePlusCommissionEmployee.GetPaymentAmount()}");
            //Console.WriteLine($"Invoice Employee Payment: {invoice.GetPaymentAmount()}");

            // use polymorphism interface to point to child object
            IPayable payable = null;

            payable = salariedEmployee;
            Console.WriteLine($"Salaried Employee Payment: {payable.GetPaymentAmount()}");

            payable = hourlyEmployee;
            Console.WriteLine($"Hourly Employee Payment: {payable.GetPaymentAmount()}");

            payable = commissionEmployee;
            Console.WriteLine($"Commission Employee Payment: {payable.GetPaymentAmount()}");

            payable = basePlusCommissionEmployee;
            Console.WriteLine($"Base+Commission Employee Payment: {payable.GetPaymentAmount()}");

            payable = invoice;
            Console.WriteLine($"Invoice Employee Payment: {payable.GetPaymentAmount()}");


            // use List for everything that implements IPayable
            List<IPayable> payables = new List<IPayable>();
            payables.Add(salariedEmployee);
            payables.Add(hourlyEmployee);
            payables.Add(commissionEmployee);
            payables.Add(basePlusCommissionEmployee);
            payables.Add(invoice);
            Console.WriteLine("\n****** Start iterating throught the list. *******");
            foreach(IPayable p in payables)
            {
                Console.WriteLine($"{p}");
                Console.WriteLine($"{p.GetPaymentAmount()}\n");
            }

            Console.ReadLine();
        }
    }
}
