using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Final
{
    public class Employee
    {
        public Employee() { }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public decimal Salary { get; set; }

        public bool IsSalaryGreater(Employee anotherEmployee)
        {
            return this.Salary > anotherEmployee.Salary;
        }
    }
    public delegate bool MyDeldgate(Employee anotherEmployee);

    class Program
    {
        static void Main(string[] args)
        {
            var e1 = new Employee() { FirstName = "spencer", LastName = "rosenvall", Salary = 1000 };
            var e2 = new Employee() { FirstName = "gavin", LastName = "rosenvall", Salary = 2000 };
            Console.WriteLine(new MyDeldgate(e1.IsSalaryGreater).Invoke(e2));
        }
    }
}
