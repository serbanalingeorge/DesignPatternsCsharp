using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.AbstractCommand;
using CommandPattern.Receiver;

namespace CommandPattern.ConcreteCommand
{
    public class AirConditionerOff : ICommand
    {
        private AirConditioner ac;

        public AirConditionerOff(AirConditioner ac)
        {
            this.ac = ac;
        }
        public void Execute()
        {
            ac.DecreaseTemp();
            ac.TurnOff();
        }
    }
}
