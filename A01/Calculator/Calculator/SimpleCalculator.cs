using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SimpleCalculator : Form
    {
        public SimpleCalculator()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblAnswer.ForeColor = Color.Green;
            if (txtNum1.Text.Replace(".", "").All(char.IsDigit) &&
                txtNum2.Text.Replace(".", "").All(char.IsDigit) &&
                !string.IsNullOrEmpty(txtNum1.Text) &&
                !string.IsNullOrEmpty(txtNum2.Text))// only accept numerical values
                lblAnswer.Text = (float.Parse(txtNum1.Text) + float.Parse(txtNum2.Text)).ToString();
            else
            {
                lblAnswer.Text = "Failed to calculate.";
                lblAnswer.ForeColor = Color.Red;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblAnswer.Text = "Ans";
            lblAnswer.ForeColor = Color.Black;
            txtNum1.Text = string.Empty;
            txtNum2.Text = string.Empty;
        }
    }
}
