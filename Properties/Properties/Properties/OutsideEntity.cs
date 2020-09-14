using System;

namespace Properties
{
    public class OutsideEntity
    {
        public void ViewEmployee(Employee employee)
        {
            Console.WriteLine("************** Employee information viewed by an outside entity **************");
            Console.WriteLine("Full Name: " + employee.FirstName + " " + employee.LastName);
            Console.WriteLine("SSN: " + employee.SSN);
            Console.WriteLine("Salary: " + employee.Salary);
            Console.WriteLine("Tax: " + employee.Tax);
            Console.WriteLine("Address: " + employee.Address);
        }
    }
}
