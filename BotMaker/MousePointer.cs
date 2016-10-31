using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace BotMaker
{
    class MousePointer:Command
    {
        public override void PerformAction()
        {
            Cursor.Position = new Point(firstValue, secondValue);
        }
    }
}
