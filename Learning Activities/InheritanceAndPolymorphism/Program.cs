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

            #region Polymorphism
            //CommissionEmployee commissionEmployee = new CommissionEmployee("Spencer", "Rosenvall", "111-55-9999", 10000m, 0.50m);
            //BasePlusCommissionEmployee basePlusCommissionEmployee
            //    = new BasePlusCommissionEmployee("Gavin", "Rosenvall", "222-54-8975", 15245m, 0.25m, 800m);
            //BasePlusCommissionEmployee basePlusCommissionEmployee2
            //    = new BasePlusCommissionEmployee("Scooby", "Doo", "222-25-8975", 75m, 0.50m, 650m);

            ////// Commission Employee Info
            ////Console.WriteLine("Commission Employee Info: ");
            ////Console.WriteLine("Gross Sales: " + commissionEmployee.GrossSales);
            //////Console.WriteLine("SSN: " + commissionEmployee.SSN);
            ////Console.WriteLine("Earning: " + commissionEmployee.Earning());

            ////// Base + Commission Employee Info
            ////Console.WriteLine("\nBase + Commission Employee Info: ");
            ////Console.WriteLine("Gross Sales: " + basePlusCommissionEmployee.GrossSales);
            //////Console.WriteLine("SSN: " + basePlusCommissionEmployee.SSN);
            ////Console.WriteLine("Earning: " + basePlusCommissionEmployee.Earning());

            ////commissionEmployee.PrintInfo();
            ////basePlusCommissionEmployee.PrintInfo();


            //Console.WriteLine("\n******* polymorphism starts *******");
            //// base class reference points to the child class object
            //// CommissionEmployee (base class) reference points to the BasePlusCommissionEmployee (child class)
            //CommissionEmployee commissionEmployee1 = new BasePlusCommissionEmployee("Gavin", "Rosenvall", "222-54-8975", 15245m, 0.25m, 800m);
            //// perform operations via inheritance

            //// calls base class method and not child class method if virtual override is not used
            //Console.WriteLine("Earning: " + commissionEmployee1.Earning());


            //Console.WriteLine("\n****** base class reference = child class reference ******");
            //commissionEmployee = basePlusCommissionEmployee;
            //Console.WriteLine("Earning: " + commissionEmployee.Earning());

            //Console.WriteLine("\n****** build an array of employees and print earnings ******");
            //CommissionEmployee[] commissionEmployeesArray = new CommissionEmployee[3];
            //commissionEmployeesArray[0] = commissionEmployee;
            //commissionEmployeesArray[1] = basePlusCommissionEmployee;
            //commissionEmployeesArray[2] = basePlusCommissionEmployee2;

            //for (int i = 0; i < commissionEmployeesArray.Length; i++)
            //    Console.WriteLine($"*** {commissionEmployeesArray[i].Earning()} ***");
            #endregion

            #region Abstract
            var salariedEmployee = new SalariedEmployee("John", "Smith", "111-111-1111", 800m);
            var hourlyEmployee = new HourlyEmployee("Karen", "Price", "222-222-222", 22.5m, 40);
            var commisionEmployee = new CommissionEmployee("Sue", "Jones", "333-333-333", 1000m, 0.06m);
            var basePlusCommissionEmployee = new BasePlusCommissionEmployee("Bob", "Lewis", "444-444-4444", 1000m, 0.04m, 300);

            // give 10% raise to BasePlusCommissionEmployee on base salary only

            //Employee employee = salariedEmployee;
            //Console.WriteLine(employee.Earning());
            //employee = hourlyEmployee;
            //Console.WriteLine(employee.Earning());

            //Employee employee = basePlusCommisionEmployee;
            //basePlusCommisionEmployee.BaseSalary = basePlusCommisionEmployee.BaseSalary * 1.1m;
            // casting
            //BasePlusCommissionEmployee b = (BasePlusCommissionEmployee)employee;
            //b.BaseSalary = b.BaseSalary * 1.1m;

            //employee = commisionEmployee;
            //CommissionEmployee c = (CommissionEmployee)employee;
            //c.CommissionRate = c.CommissionRate * 1.1m;

            Employee[] employees = new Employee[4];
            employees[0] = salariedEmployee;
            employees[1] = hourlyEmployee;
            employees[2] = commisionEmployee;
            employees[3] = basePlusCommissionEmployee;

            for (int i = 0; i < employees.Length; i++)
            {
                var emp = employees[i];
                Console.WriteLine($"{emp}\n");

                if (emp is BasePlusCommissionEmployee)
                {
                    BasePlusCommissionEmployee b = (BasePlusCommissionEmployee)emp;
                    b.BaseSalary = b.BaseSalary * 1.1m;
                }
                Console.WriteLine(emp.Earning() + "\n");
            }
            #endregion

            Console.ReadLine();
        }
    }
}
