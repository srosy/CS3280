using BusinessLayer;
using BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIFormAndMenu
{
    public partial class EmployeeForm : Form
    {
        Color OriginalGroupBoxColor = Color.White;
        Color OriginalSubmitBtnColor = Color.OrangeRed;

        List<ErrorProvider> Errors;
        List<string> IgnoreControls;
        List<string> VisibleColumns;
        Dictionary<int, string> Departments;

        public EmployeeForm()
        {
            InitializeComponent();
            EmployeeForm_Load();
        }

        private void EmployeeForm_Load()
        {
            Errors = new List<ErrorProvider>();
            Departments = new Dictionary<int, string>();
            Utility.GetDepartments().ToList().ForEach(d =>
            {
                Departments.Add(d.DeptID, d.DeptName);
            });

            IgnoreControls = new List<string>()
            {
                "Salary",
                "CommissionRate",
                "Sales",
                "Addr2",
                "Output"
            };

            VisibleColumns = new List<string>()
            {
                "FirstName",
                "LastName",
                "SSN",
                "Department"
            };

            #region Event Init Region
            btnEmployeeSubmit.MouseEnter += BtnSubmit_MouseEnter;
            btnEmployeeSubmit.MouseLeave += BtnSubmit_MouseLeave;
            tbLastName.MouseEnter += TbLastName_MouseEnter;
            tbLastName.MouseLeave += TbLastName_MouseLeave;
            tbSSN.Leave += TbSSN_Leave;
            tbZipCode.Leave += TbZipCode_Leave;
            #endregion

            #region data bindings
            var departments = Utility.GetDepartments();
            cmbDepartment.DataSource = departments;
            cmbDepartment.DisplayMember = departments.DeptNameColumn.ColumnName;
            cmbDepartment.ValueMember = departments.DeptIDColumn.ColumnName;

            cmbState.SelectedIndex = 0;

            // data grid bindings
            dgEmployee.DataSource = Utility.GetEmployees();
            #endregion

            #region Grid Settings
            // set initial values false unless in config list
            dgEmployee.Columns.OfType<DataGridViewColumn>().ToList().ForEach(c =>
            {
                if (!VisibleColumns.Contains(c.Name))
                    c.Visible = false;
            });
            dgEmployee.Columns["SSN"].ReadOnly = true;
            dgEmployee.Columns.Add(new DataGridViewButtonColumn()
            {
                HeaderText = "Use to Edit",
                Text = "Edit",
                Name = "btnEdit",
                UseColumnTextForButtonValue = true
            });
            dgEmployee.Columns.Add(new DataGridViewButtonColumn()
            {
                HeaderText = "Use to Delete",
                Text = "Delete",
                Name = "btnDelete",
                UseColumnTextForButtonValue = true
            });

            dgEmployee.CellClick += DgEmployee_CellClick;
            dgEmployee.AllowUserToAddRows = false;
            #endregion
        }

        private void TbZipCode_Leave(object sender, EventArgs e)
        {
            var isZipCode_Correct = Regex.IsMatch(tbZipCode.Text, @"\d{5}(-\d{4})?$");
            if (!isZipCode_Correct)
            {
                MessageBox.Show($"'{tbZipCode.Text}' is an invalid ZipCode. Format should be ##### or #####-####.");
                tbZipCode.Clear();
                tbZipCode.Focus();
                Helpers.InvalidateControl(tbZipCode, Errors, "Zipcode format is invalid");
            }
            else
            {
                ClearErrors(tbZipCode);
            }
        }

        private void ClearErrors([Optional] Control control)
        {
            if (control == null)
            {
                Errors.ForEach(err => err.Clear());
                Errors.Clear();
            }
            else
            {
                var error = Errors.FirstOrDefault(e => e.Tag.Equals(control.Name));
                if (error != null)
                {
                    error.Clear();
                    Errors.Remove(error);
                }
            }
        }

        private void RefreshDataGrid()
        {
            dgEmployee.DataSource = Utility.GetEmployees();
        }

        private void DgEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dg = (DataGridView)sender;
            var selectedRow = dg.Rows[e.RowIndex];

            // entire row is selected 
            if (e.ColumnIndex == -1)
            {
                PrintRow(selectedRow);
                return;
            }

            // cell is clicked, differentiate the type of cell clicked
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
                        // delete here
                        DataLayer.Context.EmployeesRow row
                            = (DataLayer.Context.EmployeesRow)((DataRowView)dgEmployee.Rows[selectedCell.RowIndex].DataBoundItem).Row;
                        bool success = Utility.DeleteEmployee(row);
                        if (success)
                        {
                            RefreshDataGrid();
                            MessageBox.Show("Successfully deleted row.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete row.");
                        }
                    }
                    else if (selectedCell.Value.Equals("Edit"))
                    {
                        var row = (DataLayer.Context.EmployeesRow)((DataRowView)dgEmployee.Rows[selectedCell.RowIndex].DataBoundItem).Row;
                        bool success = Utility.UpdateEmployee(row);
                        if (success)
                        {
                            RefreshDataGrid();
                            MessageBox.Show("Successfully saved row.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to save row.");
                        }
                    }
                }
            }
        }

        private void PrintRow(DataGridViewRow selectedRow)
        {
            tbOutput.Clear();
            var sb = new StringBuilder();

            for (int i = 2; i < dgEmployee.Columns.OfType<DataGridViewColumn>().Where(c => c.Visible).Count(); i++) // 2 skips button cols
            {
                sb.Append($"{dgEmployee.Columns[i].HeaderText} - {selectedRow.Cells[i].Value}\r\n");
            }
            tbOutput.Text = sb.ToString();
        }

        private void TbSSN_Leave(object sender, EventArgs e)
        {
            var isSSN_Correct = Regex.IsMatch(tbSSN.Text, @"^\d{3}-\d{2}-\d{4}$");
            if (!isSSN_Correct)
            {
                MessageBox.Show($"'{tbSSN.Text}' is an invalid SSN. Format should be ###-##-####.");
                tbSSN.Clear();
                tbSSN.Focus();
                Helpers.InvalidateControl(tbSSN, Errors, "SSN format is invalid");
            }
            else
            {
                ClearErrors(tbSSN);
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
            btnEmployeeSubmit.BackColor = OriginalSubmitBtnColor;
        }

        private void BtnSubmit_MouseEnter(object sender, EventArgs e)
        {
            btnEmployeeSubmit.BackColor = Color.PaleVioletRed;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OriginalGroupBoxColor = gbEmployeeType.BackColor;
            btnEmployeeSubmit.BackColor = OriginalSubmitBtnColor;
            cmbState.SelectedIndex = 0;
            rbSalaried.Checked = true;
        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbIsMarried_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbSalaried_CheckedChanged(object sender, EventArgs e)
        {
            lblSalary.Visible = true;
            tbSalary.Visible = true;
            lblSales.Visible = false;
            tbSales.Visible = false;
            lblCommissionRate.Visible = false;
            tbCommissionRate.Visible = false;
        }

        private void rbCommission_CheckedChanged(object sender, EventArgs e)
        {
            lblSalary.Visible = false;
            tbSalary.Visible = false;
            lblSales.Visible = true;
            tbSales.Visible = true;
            lblCommissionRate.Visible = true;
            tbCommissionRate.Visible = true;
        }

        private void rbBaseCommission_CheckedChanged(object sender, EventArgs e)
        {
            lblSalary.Visible = true;
            tbSalary.Visible = true;
            lblSales.Visible = true;
            tbSales.Visible = true;
            lblCommissionRate.Visible = true;
            tbCommissionRate.Visible = true;
        }

        private void btnEmployeeSubmit_Click(object sender, EventArgs e)
        {
            gbEmployeeType.BackColor = OriginalGroupBoxColor;
            ClearErrors();

            var formIsValid = true;
            foreach (Control c in this.Controls)
            {
                // add other controls as necessary
                if (c is TextBox)
                {
                    var tb = c as TextBox;
                    if (string.IsNullOrEmpty(tb.Text))
                    {
                        if (!IgnoreControls.Contains(tb.Name.Replace("tb", "")))
                        {
                            Helpers.InvalidateControl(tb, Errors);
                            formIsValid = false;
                        }
                    }
                }

                if (c is GroupBox)
                {
                    var gb = c as GroupBox;

                    var atLeastOneSelected = false;
                    foreach (RadioButton rb in gb.Controls)
                    {
                        if (rb.Checked) atLeastOneSelected = true;
                    }
                    if (!atLeastOneSelected)
                    {
                        Helpers.InvalidateControl(gb, Errors);
                        formIsValid = false;
                    }
                }
            }

            if (formIsValid)
            {
                var employee = new Employee()
                {
                    FirstName = tbFirstName.Text,
                    LastName = tbLastName.Text,
                    Address = tbAddr1.Text + " " + tbAddr2.Text,
                    State = cmbState.Items[cmbState.SelectedIndex].ToString(),
                    SSN = long.Parse(tbSSN.Text.Replace("-", "")),
                    DeptId = int.Parse(cmbDepartment.SelectedValue.ToString()),
                    EmployeeType = gbEmployeeType.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked).Text,
                    BaseSalary = string.IsNullOrEmpty(tbSalary.Text) ? 0 : long.Parse(tbSalary.Text),
                    CommissionRate = string.IsNullOrEmpty(tbCommissionRate.Text) ? 0 : float.Parse(tbCommissionRate.Text),
                    Sales = string.IsNullOrEmpty(tbSales.Text) ? 0 : int.Parse(tbSales.Text),
                    ZipCode = long.Parse(tbZipCode.Text),
                    City = tbCity.Text,
                    DOB = dtpDOB.Value,
                    JoinDate = dtpJoinDate.Value,
                    Department = Departments[int.Parse(cmbDepartment.SelectedValue.ToString())]
                };

                Utility.SaveEmployee(employee);
                RefreshDataGrid();
            }
        }

        private void ResetForm()
        {
            this.Controls.Clear();
            InitializeComponent();
            EmployeeForm_Load();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
