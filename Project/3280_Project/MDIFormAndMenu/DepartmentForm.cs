using BusinessLayer;
using BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIFormAndMenu
{
    public partial class DepartmentForm : Form
    {
        public List<ErrorProvider> Errors;
        List<string> IgnoreControls;


        public DepartmentForm()
        {
            InitializeComponent();
            DepartmentForm_Load();
        }

        private void DepartmentForm_Load()
        {
            Errors = new List<ErrorProvider>();
            IgnoreControls = new List<string>()
            {
                "Output"
            };

            tbFilter.TextChanged += TbFilter_TextChanged;

            #region data bindings           
            dgDepartments.DataSource = Utility.GetDepartments();
            #endregion

            #region Grid Settings
            dgDepartments.Columns["DeptID"].ReadOnly = true;

            dgDepartments.Columns.Add(new DataGridViewButtonColumn()
            {
                HeaderText = "Use to Edit",
                Text = "Edit",
                Name = "btnEdit",
                UseColumnTextForButtonValue = true
            });

            dgDepartments.Columns.Add(new DataGridViewButtonColumn()
            {
                HeaderText = "Use to Delete",
                Text = "Delete",
                Name = "btnDelete",
                UseColumnTextForButtonValue = true
            });

            dgDepartments.CellClick += DgDepartments_CellClick;
            dgDepartments.AllowUserToAddRows = false;
            #endregion
        }

        private void TbFilter_TextChanged(object sender, EventArgs e)
        {
            var filter = !string.IsNullOrEmpty(tbFilter.Text) ? $"DeptName LIKE '%{tbFilter.Text}%'" +
                                                                $"OR Location LIKE '%{tbFilter.Text}%'" +
                                                                $"OR ContactPersonName LIKE '%{tbFilter.Text}%'" +
                                                                $"OR ContactPersonPhone LIKE '%{tbFilter.Text}%'" : "";
            (dgDepartments.DataSource as DataTable).DefaultView.RowFilter = filter;
        }

        private void PrintRow(DataGridViewRow selectedRow)
        {
            tbOutput.Clear();
            var sb = new StringBuilder();

            for (int i = 2; i < dgDepartments.Columns.OfType<DataGridViewColumn>().Where(c => c.Visible).Count(); i++) // 2 skips button cols
            {
                sb.Append($"{dgDepartments.Columns[i].HeaderText} - {selectedRow.Cells[i].Value}\r\n");
            }
            tbOutput.Text = sb.ToString();
        }

        private void DgDepartments_CellClick(object sender, DataGridViewCellEventArgs e)
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
                        DataLayer.Context.DepartmentsRow row
                            = (DataLayer.Context.DepartmentsRow)((DataRowView)dgDepartments.Rows[selectedCell.RowIndex].DataBoundItem).Row;
                        bool success = Utility.DeleteDepartment(row);
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
                        var row = (DataLayer.Context.DepartmentsRow)((DataRowView)dgDepartments.Rows[selectedCell.RowIndex].DataBoundItem).Row;
                        bool success = Utility.UpdateDepartment(row);
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

        private void RefreshDataGrid()
        {
            dgDepartments.DataSource = Utility.GetDepartments();
        }

        private void btnDepartmentSubmit_Click(object sender, EventArgs e)
        {
            Errors.ForEach(err => err.Clear());
            Errors.Clear();

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
            }

            if (formIsValid)
            {
                var department = new Department()
                {
                    DeptName = tbDepartmentName.Text,
                    Location = tbDepartmentLocation.Text,
                    ContactPersonName = tbContactPersonName.Text,
                    ContactPersonPhone = tbContactPersonPhone.Text
                };

                Utility.SaveDepartment(department);
                RefreshDataGrid();
            }
        }
    }
}
