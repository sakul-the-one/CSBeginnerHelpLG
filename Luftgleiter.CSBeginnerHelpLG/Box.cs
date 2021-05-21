using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luftgleiter.CSBeginnerHelpLG
{
    public static class Box
    {
        public static void say(string ToSay)
        {
            Console.WriteLine(ToSay);
            MessageBox.Show(ToSay);
        }
        public static void inform(string Title, string ToSay)
        {
            Console.WriteLine(Title + " The Message " + ToSay);
            MessageBox.Show(ToSay, Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void error(string Title, string ToSay)
        {

            Console.WriteLine(Title + " The Message " + ToSay);
            MessageBox.Show(ToSay, Title, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public static bool ask(string Title, string ToSay)
        {

            Console.WriteLine(Title + " The Message " + ToSay);
            DialogResult dr = MessageBox.Show(ToSay, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) return true;
            else return false;
        }
    }
}
