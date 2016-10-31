using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace BotMaker
{
    class MouseClicker:Command
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, UIntPtr dwExtraInfo);

        public override void PerformAction()
        {
            Cursor.Position = new Point(firstValue, secondValue);
            mouse_event((int)(0x00000002), firstValue, secondValue, 0, UIntPtr.Zero);
            System.Threading.Thread.Sleep(500);
            mouse_event((int)(0x00000004), firstValue, secondValue, 0, UIntPtr.Zero);
        }
    }
}
