using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        //this is the computer

        static void Main(string[] args)
        {
            USBAdaptor usb = new USBAdaptor();
            usb.ConnectA();
            Console.WriteLine("Got the signal!");
            Console.Read();
        }
    }
}
