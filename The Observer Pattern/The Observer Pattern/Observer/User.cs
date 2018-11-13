using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Observer_Pattern.Observer
{
    public class User : ISubscriber
    {
        public void Notifty()
        {
            Console.WriteLine("User has been updated about new video");
        }
    }
}
