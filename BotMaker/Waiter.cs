using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BotMaker
{
    class Waiter:Command
    {        
        public override void PerformAction()
        {
            Random timeVariety = new Random();
            int commonTime = ((timeVariety.Next(firstValue, secondValue+1)) * 3600 + (timeVariety.Next(thirdValue, fourthValue+1)) * 60 + (timeVariety.Next(fifthValue, sixthValue+1))) * 1000;
            System.Threading.Thread.Sleep(commonTime);
        }
    }
}
