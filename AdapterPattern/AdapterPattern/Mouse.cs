using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Mouse
    {

        public void ConnectB()
        {
            Console.WriteLine("Sending signal to USB Adaptor");
        }
    }
}
