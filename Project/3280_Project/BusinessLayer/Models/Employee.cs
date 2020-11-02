using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long SSN { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public bool IsMarried { get; set; }
        public string EmployeeType { get; set; }
        public long BaseSalary { get; set; }
        public float CommissionRate { get; set; }
        public int Sales { get; set; }
        public int DeptId { get; set; }
        public long ZipCode { get; set; }
        public string City { get; set; }
        public DateTime DOB { get; set; }
        public DateTime JoinDate { get; set; }
        public string Department{ get; set; }
    }
}
