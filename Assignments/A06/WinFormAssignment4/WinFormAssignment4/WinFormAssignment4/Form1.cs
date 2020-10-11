using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAssignment4
{
    public partial class Form1 : Form
    {

        public delegate void EventHandlerCS3280(object sender, bool e);
        EventHandlerCS3280 cs3280EventHander = null;
        event EventHandlerCS3280 cs3280Event;

        public Form1()
        {
            InitializeComponent();
            cs3280EventHander = new EventHandlerCS3280(chkTest_CheckedChanged); // Initialize handler and associate it with event from object. 
            cs3280Event += cs3280EventHander; // intialize the event cs3280Event and associate it with newly Created delegate.
        }

        public void chkTest_CheckedChanged(Object sender, bool checkedStatus)
        {
            MessageBox.Show("CS 3280 Event Fired: Currently checkbox is " + (checkedStatus ? "checked" : "unchekced"));
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            cs3280Event.Invoke(sender, chkTest.Checked); // Fire the event here and and pass checkbox checked status here. 
        }
    }
}
