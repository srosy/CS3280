using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinEmployee
{
    public partial class EmployeeForm : Form
    {
        Color OriginalGroupBoxColor = Color.White;
        Color OriginalSubmitBtnColor = Color.OrangeRed;
        public EmployeeForm()
        {
            InitializeComponent();

            #region Event Init Region
            btnSubmit.MouseEnter += BtnSubmit_MouseEnter;
            btnSubmit.MouseLeave += BtnSubmit_MouseLeave;
            tbLastName.MouseEnter += TbLastName_MouseEnter;
            tbLastName.MouseLeave += TbLastName_MouseLeave;
            tbSSN.Leave += TbSSN_Leave;
            #endregion

            #region Data Bindings
            var departments = Utility.GetDepartments();
            cmbDepartment.DataSource = departments;
            cmbDepartment.DisplayMember = departments.DeptNameColumn.ColumnName; //departments.Columns["DeptName"].ColumnName;
            cmbDepartment.ValueMember = departments.DeptIDColumn.ColumnName;

            // data grid bindings
            Context.EmployeesDataTable et = Utility.GetEmployees();
            dgEmployee.DataSource = et;
            #endregion

            #region Grid Settings
            dgEmployee.Columns["EmployeeId"].Visible = false;
            dgEmployee.Columns["BaseSalary"].Visible = false;
            dgEmployee.Columns["Sales"].Visible = false;
            dgEmployee.Columns["CommissionRate"].Visible = false;
            dgEmployee.Columns["SSN"].ReadOnly = true;

            dgEmployee.Columns.Add(new DataGridViewButtonColumn()
            {
                HeaderText = "Use to Delete",
                Text = "Delete",
                Name = "btnDelete",
                UseColumnTextForButtonValue = true
            });

            dgEmployee.Columns.Add(new DataGridViewButtonColumn()
            {
                HeaderText = "Use to Edit",
                Text = "Edit",
                Name = "btnEdit",
                UseColumnTextForButtonValue = true
            });

            dgEmployee.CellClick += DgEmployee_CellClick;
            #endregion
        }

        private void RefreshGridData()
        {
            Context.EmployeesDataTable et = Utility.GetEmployees();
            dgEmployee.DataSource = et;
        }

        private void DgEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dg = (DataGridView)sender;

            var rowToOperateOn = dg.Rows[e.RowIndex];
            var currentEmpId = int.Parse(rowToOperateOn.Cells["EmployeeId"].Value.ToString());


            if (e.ColumnIndex == -1)
            {
                MessageBox.Show("You selected the entire row. Current EmployeeId is: " + currentEmpId);
                return;
            }

            // differentiate the type of cell clicked
            if (dg.SelectedCells.Count == 1)
            {
                if (dg.SelectedCells[0] is DataGridViewTextBoxCell)
                {
                    var selectedCell = (DataGridViewTextBoxCell)dg.SelectedCells[0];
                }
                else if (dg.SelectedCells[0] is DataGridViewButtonCell)
                {
                    var selectedCell = (DataGridViewButtonCell)dg.SelectedCells[0];
                    if (selectedCell.Value.Equals("Delete"))
                    {
                        MessageBox.Show("Delete clicked. Current EmployeeId is: " + currentEmpId);
                    }
                    else if (selectedCell.Value.Equals("Edit"))
                    {
                        MessageBox.Show("Edit clicked. Current EmployeeId is: " + currentEmpId);
                    }
                }
            }
        }

        private void TbSSN_Leave(object sender, EventArgs e)
        {
            var isSSN_Correct = Regex.IsMatch(tbSSN.Text, @"^\d{3}-\d{2}-\d{4}$");
            if (!isSSN_Correct)
            {
                MessageBox.Show($"'{tbSSN.Text}' is an invalid SSN. Format should be ###-##-####.");
                tbSSN.Clear();
                tbSSN.Focus();
            }
        }

        private void TbLastName_MouseLeave(object sender, EventArgs e)
        {
            tbLastName.Size = new Size(tbLastName.Size.Width - 20, tbLastName.Size.Height - 10);
            tbLastName.Multiline = false;
        }

        private void TbLastName_MouseEnter(object sender, EventArgs e)
        {
            tbLastName.Size = new Size(tbLastName.Size.Width + 20, tbLastName.Size.Height + 10);
            tbLastName.Multiline = true;
        }

        private void BtnSubmit_MouseLeave(object sender, EventArgs e)
        {
            btnSubmit.BackColor = OriginalSubmitBtnColor;
        }

        private void BtnSubmit_MouseEnter(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.PaleVioletRed;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OriginalGroupBoxColor = gbEmployeeType.BackColor;
            btnSubmit.BackColor = OriginalSubmitBtnColor;
            gbEmployeeType.BackColor = Color.Azure;
            cmbState.SelectedIndex = 0;
            rbSalaried.Checked = true;
        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show($"{cmbState.SelectedItem.ToString()} ({cmbState.SelectedIndex.ToString()})");
        }

        private void cbIsMarried_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show($"cbIsMarried is checked: {cbIsMarried.Checked}");
        }

        private void rbSalaried_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show($"Salaried: {rbSalaried.Checked}\nCommission: {rbCommission.Checked}\nBase+Commission: {rbBaseCommission.Checked}");
            lblSalary.Visible = true;
            tbSalary.Visible = true;
            lblSales.Visible = false;
            tbSales.Visible = false;
            lblCommissionRate.Visible = false;
            tbCommissionRate.Visible = false;
        }

        private void rbCommission_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show($"Salaried: {rbSalaried.Checked}\nCommission: {rbCommission.Checked}\nBase+Commission: {rbBaseCommission.Checked}");
            lblSalary.Visible = false;
            tbSalary.Visible = false;
            lblSales.Visible = true;
            tbSales.Visible = true;
            lblCommissionRate.Visible = true;
            tbCommissionRate.Visible = true;
        }

        private void rbBaseCommission_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show($"Salaried: {rbSalaried.Checked}\nCommission: {rbCommission.Checked}\nBase+Commission: {rbBaseCommission.Checked}");
            lblSalary.Visible = true;
            tbSalary.Visible = true;
            lblSales.Visible = true;
            tbSales.Visible = true;
            lblCommissionRate.Visible = true;
            tbCommissionRate.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {



            gbEmployeeType.BackColor = OriginalGroupBoxColor;

            Utility.SaveEmployee(tbFirstName.Text, tbLastName.Text, tbSSN.Text, cmbDepartment.SelectedValue.ToString(), tbSalary.Text, tbCommissionRate.Text, tbSales.Text);
        }
    }
}
