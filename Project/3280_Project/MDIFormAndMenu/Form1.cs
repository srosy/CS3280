using System;
using System.Windows.Forms;

namespace MDIFormAndMenu
{
    public partial class Form1 : Form
    {
        EmployeeForm ef;
        DepartmentForm df;

        public Form1()
        {
            InitializeComponent();
            ef = new EmployeeForm() { MdiParent = this };
            df = new DepartmentForm() { MdiParent = this };
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            df.Hide();
            ef.Show();
        }

        private void departmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ef.Hide();
            df.Show();
        }
    }
}
