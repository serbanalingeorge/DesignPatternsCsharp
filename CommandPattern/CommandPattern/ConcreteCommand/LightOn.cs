using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.AbstractCommand;
using CommandPattern.Receiver;

namespace CommandPattern.ConcreteCommand
{
    public class LightOn : ICommand
    {
        private Light light;

        public LightOn(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.On();
        }
    }
}
