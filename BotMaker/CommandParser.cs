using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BotMaker
{
    class CommandParser
    {
        public Command Parse(string command)
        {
            Command action=new MousePointer();

            string[] actionExtracter = command.Split('(');
            string actionName = actionExtracter[0];

            switch (actionName)
            {
                case "Click": action = new MouseClicker(); break;
                case "Drag": action = new MouseDragger(); break;
                case "Point": action = new MousePointer(); break;
            }

            if (actionName == "Wait")
            {
                action.name = actionName;
                action = new Waiter();

                actionExtracter = actionExtracter[1].Split(':');
                action.firstValue = Convert.ToInt32(actionExtracter[0].Split('-')[0]);
                action.secondValue = Convert.ToInt32(actionExtracter[0].Split('-')[1]);
                action.thirdValue = Convert.ToInt32(actionExtracter[1].Split('-')[0]);
                action.fourthValue = Convert.ToInt32(actionExtracter[1].Split('-')[1]);
                action.fifthValue = Convert.ToInt32(actionExtracter[2].Split('-')[0]);
                action.sixthValue = Convert.ToInt32(actionExtracter[2].Split('-')[1].Split(')')[0]);                

                return action;
            }
            
            actionExtracter = actionExtracter[1].Split(',');
            action.firstValue = Convert.ToInt32(actionExtracter[0]);
            actionExtracter = actionExtracter[1].Split(')');
            action.secondValue = Convert.ToInt32(actionExtracter[0]);
            
            action.name = actionName;

            return action;
        }
    }
}
