using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Observer_Pattern.Observer
{
    public class Moderator : ISubscriber
    {
        public void Notifty()
        {
            Console.WriteLine("Moderator needs to review new video!");
        }
    }
}
