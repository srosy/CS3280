using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class Utility
    {
        public static Context.DepartmentsDataTable GetDepartments()
        {
            var dt = new Context.DepartmentsDataTable();
            var adapter = new ContextTableAdapters.DepartmentsTableAdapter();
            adapter.Fill(dt);

            return dt;
        }

        public static void SaveEmployee(string fname, string lname, string ssn, string deptID, string salary, string commissionRate, string sales)
        {
            var SSN = int.Parse(ssn);
            var DeptID = int.Parse(deptID);
            var Salary = int.Parse(salary);
            var Commissionrate = float.Parse(commissionRate);
            var Sales = int.Parse(sales);

            var et = new Context.EmployeesDataTable();
            var adapter = new ContextTableAdapters.EmployeesTableAdapter();
            adapter.Fill(et);

            var employee = et.NewEmployeesRow();
            employee.SSN = SSN;
            employee.DeptId = DeptID;
            employee.BaseSalary = Salary;
            employee.CommissionRate = Commissionrate;
            employee.Sales = Sales;
            et.AddEmployeesRow(employee);

            adapter.Update(et);
        }

        public static Context.EmployeesDataTable GetEmployees()
        {
            var et = new Context.EmployeesDataTable();
            var adapter = new ContextTableAdapters.EmployeesTableAdapter();
            adapter.Fill(et);

            return et;
        }
    }
}
