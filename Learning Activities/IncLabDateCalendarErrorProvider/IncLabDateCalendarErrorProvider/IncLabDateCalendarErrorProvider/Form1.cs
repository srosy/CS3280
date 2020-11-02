using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace IncLabDateCalendarErrorProvider
{
    public partial class DateCalendarError : Form
    {
        public DateCalendarError()
        {
            InitializeComponent();
            dtClassPicker.DateSelected += MonthCalendar1_DateSelected;
            dtClassPicker.AddBoldedDate(DateTime.Parse("01/01/2020"));
            dtClassPicker.AddBoldedDate(DateTime.Parse("01/15/2020"));
        }

        private void MonthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime dt = e.Start;

            if (dtClassPicker.BoldedDates.ToList<DateTime>().Exists(x => x.Date == dt))
                MessageBox.Show("CS3550 is Today.");
        }

        private void btnValidateSSN_Click(object sender, EventArgs e)
        {
            string regex = @"^\d{3}-?\d{2}-?\d{4}$";
            if (Regex.IsMatch(tbSSN.Text, regex))
            {
                MessageBox.Show("SSN is valid.");
                validation.Clear();
            }
            else
            {
                validation.SetError(tbSSN, "SSN is invalid.");
            }
        }

        private void btnBirthdayCheck_Click(object sender, EventArgs e)
        {
            DateTime dt = bDayPicker.Value;
            DateTime myBirthday = DateTime.Parse("11/09/1994");
            if (myBirthday.Date.Equals(dt.Date))
            {
                MessageBox.Show("\"It is your birthday.\" - Dwight Schrute (The Office)");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            validation.Clear();
        }
    }
}
