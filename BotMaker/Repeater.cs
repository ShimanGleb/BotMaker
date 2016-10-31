using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BotMaker
{
    public class Repeater
    {
        int repeatsAmount;
        public int leftRepeats;
        public int startingCommand;
        public int lastCommand;
        public int influencedRepeaters;        

        public void Repeat(ref int i)
        {
            if (i == lastCommand)
            {
                i = startingCommand - 1;
            }
        }

        public void SetRepeatsAmount(int amount)
        {
            repeatsAmount = amount;
            leftRepeats = amount;
        }

        public void RestoreRepeats()
        {
            leftRepeats = repeatsAmount;
        }
    }
}
