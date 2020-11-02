using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIFormAndMenu
{
    public static class Helpers
    {
        public static void InvalidateControl(Control c, List<ErrorProvider> errors, [Optional] string message)
        {
            var newError = new ErrorProvider()
            {
                BlinkStyle = ErrorBlinkStyle.NeverBlink
            };
            newError.SetIconAlignment(c, ErrorIconAlignment.MiddleRight);
            newError.SetIconPadding(c, 2);
            newError.Tag = c.Name;
            newError.SetError(c, !string.IsNullOrEmpty(message) ? message : "Invalid Value");
            errors.Add(newError);
        }
    }
}
