using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BotMaker
{
    public abstract class Command
    {
        public string name;
        public int firstValue;
        public int secondValue;
        public int thirdValue;
        public int fourthValue;
        public int fifthValue;
        public int sixthValue;

        public abstract void PerformAction();
    }
}
