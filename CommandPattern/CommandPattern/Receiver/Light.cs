using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Receiver
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Lights are on!");
        }

        public void Off()
        {
            Console.WriteLine("Lights are off!");
        }
    }
}
