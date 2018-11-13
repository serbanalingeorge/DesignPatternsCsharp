using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.AbstractCommand;

namespace CommandPattern.Invoker
{
    public class RemoteController
    {
        private IList<ICommand> turnOnCommands = new List<ICommand>(); //AC ON, Light on
        private IList<ICommand> turnOffCommands = new List<ICommand>(); //AC OFF, Light off

        public void InsertNewOnCommand(ICommand command)
        {
            turnOnCommands.Add(command);
        }

        public void InsertNewOffCommand(ICommand command)
        {
            turnOffCommands.Add(command);
        }

        public void PressButtonOn(int buttonNumber)
        {
            turnOnCommands[buttonNumber].Execute();
        }

        public void PressButtonOff(int buttonNumber)
        {
            turnOffCommands[buttonNumber].Execute();
        }
    }
}
