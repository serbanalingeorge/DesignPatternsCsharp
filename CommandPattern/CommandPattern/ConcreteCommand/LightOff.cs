using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.AbstractCommand;
using CommandPattern.Receiver;

namespace CommandPattern.ConcreteCommand
{
    public class LightOff : ICommand
    {
        private Light light;

        public LightOff(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.Off();
        }
    }
}
