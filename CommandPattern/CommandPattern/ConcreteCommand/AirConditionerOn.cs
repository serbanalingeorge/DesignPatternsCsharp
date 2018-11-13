using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.AbstractCommand;
using CommandPattern.Receiver;

namespace CommandPattern.ConcreteCommand
{
    public class AirConditionerOn : ICommand
    {
        private AirConditioner ac;

        public AirConditionerOn(AirConditioner ac)
        {
            this.ac = ac;
        }
        public void Execute()
        {
            ac.TurnOn();
            ac.IncreaseTemp();
        }
    }
}
