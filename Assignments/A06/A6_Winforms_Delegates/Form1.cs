using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A6_Winforms_Delegates
{
    public partial class Form1 : Form
    {
        List<RadioButton> rbs;
        public delegate void EventHandler(RadioButton rb);
        EventHandler MyEventHandler = null;
        event EventHandler MyEvent;

        public Form1()
        {
            InitializeComponent();
            MyEventHandler = new EventHandler(DoComputation);
            MyEvent += MyEventHandler;
            rbs = new List<RadioButton>()
            {
                rbSquare,
                rbSquareRoot,
                rbCube
            };
        }

        private void DoComputation(RadioButton rb) // passing the sender is unecessary
        {
            var num = double.Parse(tbNumber.Text);
            var result = 0d;
            switch (rb.Text.ToLower())
            {
                case "square": result = MathSingleParameterOperations.Square(num); break;
                case "square root": result = MathSingleParameterOperations.SquareRoot(num); break;
                case "cube": result = MathSingleParameterOperations.Cube(num); break;
                default: throw new ArgumentException("Idk how you got here so kudos to you. Stop making my life difficult.");
            }
            MessageBox.Show($"The result for this computation is: {string.Format("{0:0.##}", result)}!");
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            if (rbs.Count(b => b.Checked) < 1)
                MessageBox.Show("No bueno dude, at least select one radiobutton.");
            else if (string.IsNullOrEmpty(tbNumber.Text))
                MessageBox.Show("No bueno dude, the textbox can't be empty.");
            else if (!double.TryParse(tbNumber.Text, out _))
                MessageBox.Show("No bueno dude, the textbox value must be a number.");
            else
                MyEvent.Invoke(rbs.Where(b => b.Checked == true).FirstOrDefault());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
