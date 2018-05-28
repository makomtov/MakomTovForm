using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMT
{
    public static class ErrorProviderExtensions
    {
        private static int count;

        public static void SetErrorWithCount(this ErrorProvider ep, Control c, string message)
        {
            if (message == "")
            {
                if (ep.GetError(c) != "")
                    count--;
            }
            else
               if (ep.GetError(c) == "")
                count++;

            ep.SetError(c, message);
        }

        public static bool HasErrors(this ErrorProvider ep)
        {
            return count != 0;
        }

        public static int GetErrorCount(this ErrorProvider ep)
        {
            return count;
        }

        public static void checkEmpty(this ErrorProvider ep,TextBox textBox, string message)
        {
            if (textBox.Text == string.Empty)
            {
                ErrorProviderExtensions.SetErrorWithCount( ep, textBox, message);
            }
            else
                ErrorProviderExtensions.SetErrorWithCount(ep, textBox, "");
        }
        
       
        public static void regexValidate(this ErrorProvider ep,TextBox textBox, string regex, string message)
        {
            Regex regEmail = new Regex(regex);
            if (!regEmail.IsMatch(textBox.Text))
            {
                ErrorProviderExtensions.SetErrorWithCount(ep, textBox, message);
                
            }
            else
            {
                ErrorProviderExtensions.SetErrorWithCount(ep, textBox, "");
            }

        }
    }
}

