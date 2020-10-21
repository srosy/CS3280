using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet
{
    class Program
    {
        static void Main(string[] args)
        {
            // create db adapter
            OrganizationTableAdapters.DepartmentsTableAdapter deptAdapter
                = new OrganizationTableAdapters.DepartmentsTableAdapter(); // build adapter
            Organization.DepartmentsDataTable dt = new Organization.DepartmentsDataTable(); // create data table
            deptAdapter.Fill(dt); // fill the table

            // read rows
            foreach (Organization.DepartmentsRow r in dt.Rows)
            {
                Console.WriteLine($"{r.DeptID}\t{r.DeptName}\t{r.Location}");
            }

            // insert a new row
            var row = dt.NewDepartmentsRow();
            row.DeptName = "NewDepartment";
            row.Location = "NewLocation";
            dt.AddDepartmentsRow(row);

            // update an existing row
            Organization.DepartmentsRow updateRow = dt.FindByDeptID(4);
            updateRow.Location = "SLC";

            // delete a row
            var rowsToDelete = dt.Where(d => d.Location == "SLC");
            foreach (var r in rowsToDelete)
            {
                deptAdapter.Delete(r.DeptID, r.DeptName, r.Location);
            }

            deptAdapter.Update(dt);

            Console.WriteLine();
        }
    }
}
