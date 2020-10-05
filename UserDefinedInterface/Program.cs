using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedInterface
{
    class Program
    {
        static readonly decimal HIGHER_EARNING = 750;
        static readonly decimal INFLATION_RATE = 0.2m;

        static void Main(string[] args)
        {
            SalariedEmployee salariedEmployee = new SalariedEmployee("John", "Smith", "111-11-1111", 800m);
            HourlyEmployee hourlyEmployee = new HourlyEmployee("Karen", "Price", "222-22-2222", 22.5m, 40);
            CommissionEmployee commissionEmployee = new CommissionEmployee("Sue", "Jones", "333-33-3333", 1000m, 0.10m);
            BasePlusCommissionEmployee basePlusCommissionEmployee = new BasePlusCommissionEmployee("Bob", "Lewis", "444-44-4444", 1000m, 0.25m, 12m);
            BasePlusCommissionEmployee basePlusCommissionEmployee2 = new BasePlusCommissionEmployee("Alex", "Lewis", "555-44-4444", 1000m, 0.25m, 350);
            //Invoice invoice = new Invoice("Part1", "Part 1 Desc", 10, 4.99m);

            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(salariedEmployee);
            employeeList.Add(hourlyEmployee);
            employeeList.Add(commissionEmployee);
            employeeList.Add(basePlusCommissionEmployee);
            employeeList.Add(basePlusCommissionEmployee2);
            
            foreach (Employee e in employeeList)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("*** Starting LINQ ***");

            // filtering...
            var higherEarnerList = employeeList.Where(e => e.Earning() >= 750).ToList();
            employeeList.ForEach(e => Console.WriteLine(e));
            // find all employees whose last name is Lewis
            Console.WriteLine("*** Print employees with last name Lewis ***");
            var lewisList = employeeList.Where(e => e.LastName.ToLower().Equals("lewis")).ToList();
            lewisList.ForEach(e => Console.WriteLine(e));
            // find all employees whose last name starts with S
            Console.WriteLine("*** Print employees with last name starts with S ***");
            var sList = employeeList.Where(e => e.LastName.ToLower().StartsWith("s")).ToList();
            sList.ForEach(e => Console.WriteLine(e));
            // start projection operation
            Console.WriteLine("*** Starting projection operation ***");
            var ssnOfHigherEarnerList = employeeList.Where(e => e.Earning() >= HIGHER_EARNING).Select(e => e.SSN).ToList();
            ssnOfHigherEarnerList.ForEach(e => Console.WriteLine(e));
            Console.WriteLine("*** fins SSN of all employees ***");
            var ssnOfAllEmployees = employeeList.Select(e => e.SSN).ToList();
            ssnOfAllEmployees.ForEach(e => Console.WriteLine(e));
            // f and l name of high earners
            Console.WriteLine("*** Find the first and last name of all the high earners ***");
            var firstLastOfHigherEarners = employeeList.Where(e => e.Earning() >= HIGHER_EARNING).Select(e => e.FirstName + " " + e.LastName).ToList();
            firstLastOfHigherEarners.ForEach(e => Console.WriteLine(e));
            // f and l name and earning of high earners
            Console.WriteLine("*** Find the first and last name and earning of all the high earners ***");
            var firstLastOfHigherAndEarningEarners = higherEarnerList.Select(e => e.FirstName + " " + e.LastName + " " + e.Earning()).ToList();
            firstLastOfHigherAndEarningEarners.ForEach(e => Console.WriteLine(e));

            // sorting...
            Console.WriteLine("*** Ordering Operation ***");
            Console.WriteLine("*** Sort the employee by first name asc ***");
            var emplyeesSortedByFirstName = employeeList.OrderBy(e => e.FirstName).ToList();
            emplyeesSortedByFirstName.ForEach(e => Console.WriteLine(e));
            Console.WriteLine("*** Sort the employee by first name desc ***");
            var employeesSortedByFirstNameDesc = employeeList.OrderByDescending(e => e.FirstName).ToList();
            employeesSortedByFirstNameDesc.ForEach(e => Console.WriteLine(e));
            Console.WriteLine("*** Sort the employee by earning ***");
            var employeesSortedByEarning = employeeList.OrderBy(e => e.Earning()).ToList();
            employeesSortedByEarning.ForEach(e => Console.WriteLine(e));
            Console.WriteLine("*** Sort the employee by earning and last name ***");
            var employeesSortedByEarningAndLastName = higherEarnerList.OrderBy(e => e.LastName).ToList();
            employeesSortedByEarningAndLastName.ForEach(e => Console.WriteLine(e));

            // aggregation...
            Console.WriteLine("*** Aggregation ***");
            Console.WriteLine("*** Find total cost associated with all employees ***");
            var totalCost = employeeList.Sum(e => e.Earning());
            Console.WriteLine("*** Find average cost associated with all employees ***");
            var averageCost = employeeList.Where(e => e.Earning() >= HIGHER_EARNING).Average(e => e.Earning());

            // group by
            var groupedByLastName = employeeList.GroupBy(e => e.LastName).ToList();

            Console.ReadLine();
        }
    }
}
