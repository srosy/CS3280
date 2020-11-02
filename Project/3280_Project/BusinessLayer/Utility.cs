using BusinessLayer.Models;
using DataLayer;
using System;
using System.Runtime.InteropServices;
using static DataLayer.Context;

namespace BusinessLayer
{
    public static class Utility
    {
        #region Public Methods
        /// <summary>
        /// Handles if multiple Employees should be saved or single, then saves.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="cloneCount"></param>
        /// <returns></returns>
        public static int SaveEmployee(Employee e, [Optional] int cloneCount)
        {
            if (e == null) return 0;

            var numRowsUpdated = 0;
            if (cloneCount > 1)
            {
                for (int i = 0; i < cloneCount; i++)
                {
                    numRowsUpdated += SaveEmployee(e);
                }
            }
            else
            {
                numRowsUpdated += SaveEmployee(e);
            }

            return numRowsUpdated; // success > 0
        }

        /// <summary>
        /// Gets Employees from DataLayer.
        /// </summary>
        /// <returns></returns>
        public static DataLayer.Context.EmployeesDataTable GetEmployees()
        {
            return DataLayer.Utility.GetEmployees();
        }

        /// <summary>
        /// Handles if multiple Departments should be saved or single, then saves.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="cloneCount"></param>
        /// <returns></returns>
        public static int SaveDepartment(Department d, [Optional] int cloneCount)
        {
            if (d == null) return 0;

            var numRowsUpdated = 0;
            if (cloneCount > 1)
            {
                for (int i = 0; i < cloneCount; i++)
                {
                    numRowsUpdated += SaveDepartment(d);
                }
            }
            else
            {
                numRowsUpdated += SaveDepartment(d);
            }

            return numRowsUpdated; // success > 0
        }

        /// <summary>
        /// Gets Departments from DataLayer.
        /// </summary>
        /// <returns></returns>
        public static DataLayer.Context.DepartmentsDataTable GetDepartments()
        {
            return DataLayer.Utility.GetDepartments();
        }
        #endregion

        #region Private Methods
        private static int SaveEmployee(Employee employee)
        {
            DataLayer.Utility.EmployeesTableAdapter.Fill(DataLayer.Utility.Employees);
            var e = DataLayer.Utility.Employees.NewEmployeesRow();
            e.Address = employee.Address;
            e.BaseSalary = employee.BaseSalary;
            e.CommissionRate = employee.CommissionRate;
            e.DeptId = employee.DeptId;
            e.EmployeeId = employee.EmployeeId;
            e.EmployeeType = employee.EmployeeType;
            e.FirstName = employee.FirstName;
            e.IsMarried = employee.IsMarried;
            e.LastName = employee.LastName;
            e.SSN = employee.SSN;
            e.State = employee.State;
            e.Sales = employee.Sales;
            e.ZipCode = employee.ZipCode;
            e.JoinDate = employee.JoinDate;
            e.DOB = employee.DOB;
            e.Department = employee.Department;

            return DataLayer.Utility.SaveEmployee(e) ? 1 : 0;
        }

        private static int SaveDepartment(Department department)
        {
            DataLayer.Utility.DepartmentsTableAdapter.Fill(DataLayer.Utility.Departments);
            var d = DataLayer.Utility.Departments.NewDepartmentsRow();
            d.DeptID = department.DeptID;
            d.DeptName = department.DeptName;
            d.Location = department.Location;
            d.ContactPersonName = department.ContactPersonName;
            d.ContactPersonPhone = department.ContactPersonPhone;

            return DataLayer.Utility.SaveDepartment(d) ? 1 : 0;
        }

        public static bool DeleteEmployee(EmployeesRow row)
        {
            return DataLayer.Utility.DeleteEmployee(row);
        }

        public static bool UpdateEmployee(EmployeesRow row)
        {
            return DataLayer.Utility.UpdateEmployee(row);
        }

        public static bool DeleteDepartment(DepartmentsRow row)
        {
            return DataLayer.Utility.DeleteDepartment(row);
        }

        public static bool UpdateDepartment(DepartmentsRow row)
        {
            return DataLayer.Utility.UpdateDepartment(row);
        }
        #endregion
    }
}

