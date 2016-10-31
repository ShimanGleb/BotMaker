using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace BotMaker
{
    class MouseDragger:Command
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, UIntPtr dwExtraInfo);

        public override void PerformAction()
        {
            mouse_event((int)(0x00000002), Cursor.Position.X, Cursor.Position.Y, 0, UIntPtr.Zero);
            Cursor.Position = new Point(firstValue, secondValue);
            mouse_event((int)(0x00000004), Cursor.Position.X, Cursor.Position.Y, 0, UIntPtr.Zero);
        }
    }
}
