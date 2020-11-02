using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        public string Location { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactPersonPhone { get; set; }
    }
}
