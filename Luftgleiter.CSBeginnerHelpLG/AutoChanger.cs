using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luftgleiter.CSBeginnerHelpLG
{
    public class AutoChanger
    {
        public static Size AutoScale(Form Form, int OffSetWidth, int OffSetHeight)
        {
            int WOY = Form.Height - OffSetHeight;
            int WOX = Form.Width - OffSetWidth;
            return new Size(WOX, WOY);
        }
        public static Point MovingPanel(bool MouseDown, Control MovingControl, MouseEventArgs MousePosition)
        {
            if (MouseDown == true) return new Point(MousePosition.X, MousePosition.Y);
            else return new Point(MovingControl.Location.X, MovingControl.Location.Y);
        }
    }
}
