using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagementSystemLibrary
{
    public static class StaticFunctionsEvents
    {
        public static void KeyCharLetters(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        public static void KeyCharNumbers(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
