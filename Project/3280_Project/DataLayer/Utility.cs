using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class Utility
    {
        public static readonly ContextTableAdapters.DepartmentsTableAdapter DepartmentsTableAdapter
            = new ContextTableAdapters.DepartmentsTableAdapter();
        public static readonly Context.DepartmentsDataTable Departments = GetDepartments();

        public static readonly ContextTableAdapters.EmployeesTableAdapter EmployeesTableAdapter
            = new ContextTableAdapters.EmployeesTableAdapter();
        public static readonly Context.EmployeesDataTable Employees = GetEmployees();

        /// <summary>
        /// Gets Employees from the database.
        /// </summary>
        /// <returns></returns>
        public static Context.EmployeesDataTable GetEmployees()
        {
            var dt = new Context.EmployeesDataTable();
            EmployeesTableAdapter.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Gets Departments from the database.
        /// </summary>
        /// <returns></returns>
        public static Context.DepartmentsDataTable GetDepartments()
        {
            var dt = new Context.DepartmentsDataTable();
            DepartmentsTableAdapter.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Saves Employees to the database.
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public static bool SaveEmployee(Context.EmployeesRow row)
        {
            Employees.AddEmployeesRow(row);
            var updateSuccessfull = EmployeesTableAdapter.Update(Employees) > 0;
            return updateSuccessfull; // success > 0
        }

        /// <summary>
        /// Saves Departments to the database.
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public static bool SaveDepartment(Context.DepartmentsRow row)
        {
            Departments.AddDepartmentsRow(row);
            var updateSuccessfull = DepartmentsTableAdapter.Update(Departments) > 0;
            return updateSuccessfull; // success > 0
        }

        /// <summary>
        /// Updates an existing Employee in the DB.
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public static bool UpdateEmployee(Context.EmployeesRow row)
        {
            foreach (Context.EmployeesRow e in Employees.Rows)
            {
                if (e.EmployeeId == row.EmployeeId)
                {
                    e.FirstName = row.FirstName;
                    e.LastName = row.LastName;
                    e.SSN = row.SSN;
                    break;
                }
            }
            return EmployeesTableAdapter.Update(Employees) > 0;
        }

        /// <summary>
        /// Deletes the matching employee from the DB.
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public static bool DeleteEmployee(Context.EmployeesRow row)
        {
            var deleted = false;
            var rowToDelete = Employees.Where(r => r.EmployeeId == row.EmployeeId).FirstOrDefault();
            if (rowToDelete != null)
            {
                deleted = EmployeesTableAdapter.Delete(rowToDelete.EmployeeId,
                    rowToDelete.FirstName,
                    rowToDelete.LastName,
                    rowToDelete.SSN,
                    rowToDelete.State,
                    rowToDelete.IsMarried,
                    rowToDelete.EmployeeType,
                    rowToDelete.BaseSalary,
                    rowToDelete.CommissionRate,
                    rowToDelete.Sales,
                    rowToDelete.DeptId,
                    rowToDelete.ZipCode,
                    rowToDelete.DOB,
                    rowToDelete.JoinDate,
                    rowToDelete.Department) > 0;
            }
            return deleted;
        }

        /// <summary>
        /// Update matching Departments in the DB.
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public static bool UpdateDepartment(Context.DepartmentsRow row)
        {
            foreach (Context.DepartmentsRow d in Departments.Rows)
            {
                if (d.DeptID == row.DeptID)
                {
                    d.DeptName = row.DeptName;
                    d.Location = row.Location;
                    d.ContactPersonName = row.ContactPersonName;
                    d.ContactPersonPhone = row.ContactPersonPhone;
                    break;
                }
            }
            return DepartmentsTableAdapter.Update(Departments) > 0;
        }

        /// <summary>
        /// Deletes the matching employee from the DB.
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public static bool DeleteDepartment(Context.DepartmentsRow row)
        {
            var deleted = false;
            var rowToDelete = Departments.Where(r => r.DeptID == row.DeptID).FirstOrDefault();
            if (rowToDelete != null)
            {
                deleted = DepartmentsTableAdapter.Delete(
                    rowToDelete.DeptID,
                    rowToDelete.DeptName,
                    rowToDelete.Location,
                    rowToDelete.ContactPersonName,
                    rowToDelete.ContactPersonPhone
                    ) > 0;
            }
            return deleted;
        }
    }
}
