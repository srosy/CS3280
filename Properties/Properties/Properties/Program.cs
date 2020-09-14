using System;

namespace Properties
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee empJohnDoe = new Employee("Jonh", "Doe", "111-111-1111", 35000m);
            empJohnDoe.FirstName = "John";
            Employee empJaneLee = new Employee("Jane", "Lee", "222-222-2222", 40000m, "123 Main St Layton UT");

            Console.WriteLine("Jane SSN: " + empJaneLee.SSN);
            Console.WriteLine("Jane Address: " + empJaneLee.Address);

            empJaneLee.Address = "123 Main St Ogden UT";
            Console.WriteLine("Jane Address: " + empJaneLee.Address);

            Console.WriteLine("Full name Jane: " + empJaneLee.FullName);
            Console.WriteLine("Jane lee tax before calculation is: " + empJaneLee.Tax);

            empJaneLee.ComputeTax(0.12m);
            Console.WriteLine("Jane lee tax after calculation is: " + empJaneLee.Tax);

            Employee empArpit = new Employee("Arpit", "Christi", "333-333-3333");

            try
            {
                empArpit.Salary = 20000m;
            }
            catch (ArgumentOutOfRangeException argumentOutOfRangeException)
            {
                Console.WriteLine("ERRROR: " + argumentOutOfRangeException.Message);
            }
            Console.WriteLine("Full name Arpit: " + empArpit.FullName + "\n");

            OutsideEntity outsideEntity = new OutsideEntity();
            outsideEntity.ViewEmployee(empJohnDoe);

            Console.WriteLine("\n****** Printing Jane Lee Employee Information ******\n");
            empJaneLee.PrintEmployeeInfo();


            Console.WriteLine("\n***** Starting Unit 4 LA *****");
            Console.WriteLine(new Employee().FirstName); // null/empty firstname, returns stars
            Console.WriteLine(new Employee().LastName); // null/empty lastname, returns stars

            // attempt to set firstname to empty string, error occurs
            try
            {
                empArpit.FirstName = string.Empty;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n" + ex.Message + "\n");
            }

            Console.ReadLine();
        }
    }
}
