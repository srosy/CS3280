using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Final_Q17
{
    public partial class Final_Q17 : Form
    {
        private Dictionary<string, ErrorProvider> errors = new Dictionary<string, ErrorProvider>();
        public Final_Q17()
        {
            InitializeComponent();

            #region Event Handlers
            tbClassName.Leave += Tb_Leave;
            tbClassCode.Leave += Tb_Leave;
            tbClassDays.Leave += Tb_Leave;
            tbStartTime.Leave += Tb_Leave;
            tbEndTime.Leave += Tb_Leave;
            #endregion

            this.ActiveControl = tbClassName;
        }

        private void Tb_Leave(object sender, EventArgs e)
        {
            var obj = sender as TextBox;
            var createError = string.IsNullOrEmpty(obj.Text);
            var message = string.Empty;

            var name = obj.Name.ToLower();

            if (name.Contains("code"))
            {
                if (!obj.Text.ToLower().Contains("cs") || obj.Text.Length != 6)
                {
                    createError = true;
                    message = $"Input value [{obj.Text}] does not match expected format: [CS####]";
                }
            }

            if (name.Contains("day"))
            {
                try
                {
                    var splitTest = obj.Text.Split(',');
                    var allowedDayCodes = new string[]
                    {
                        "S", "M", "T", "W", "Th", "F", "SA"
                    };

                    if (!obj.Text.Split(',').ToList().All(s => allowedDayCodes.Contains(s) ||
                        allowedDayCodes.Select(sl => sl.ToLower()).Contains(s)))
                    {
                        message = $"Input value [{obj.Text}] does not match expected format: [S,M,T,W,TH,F,SA]";
                        createError = true;
                    }
                }
                catch
                {
                    message = $"Input value [{obj.Text}] does not match expected format: [S,M,T,W,TH,F,SA]";
                    createError = true;
                }
            }

            if (createError) CreateError(obj, message);
            else
            {
                var error = errors.FirstOrDefault(err => err.Key == obj.Name).Value;
                if (error != null)
                {
                    errors.Remove(obj.Name);
                    error.Dispose();
                }
            }
        }

        private void CreateError(Control c, string message)
        {
            if (string.IsNullOrEmpty(message)) message = "cannot be empty";

            var error = new ErrorProvider();
            error.SetIconAlignment(c, ErrorIconAlignment.MiddleRight);
            error.SetIconPadding(c, 2);
            error.BlinkRate = 1000;
            error.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            error.DataSource = c;
            error.SetError(c, message);

            if (!errors.ContainsKey(c.Name))
                errors.Add(c.Name, error);

            c.Focus();

            MessageBox.Show(message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (errors.Count == 0)
            {
                var filteredControls = new List<TextBox>();
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        var tb = c as TextBox;
                        filteredControls.Add(tb);
                    }
                }

                var message = "Successfully Submitted Form!\r\n" +
                              "--------------------------------------\r\n\n";
                filteredControls.ForEach(c =>
                {
                    message += $"{c.Name}:{c.Text}\r\n";
                });
                MessageBox.Show(message);
            }
        }
    }
}
