using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Observer_Pattern.Observer;
using The_Observer_Pattern.Subject;

namespace The_Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            YouTubeChannel Youtube = new YouTubeChannel(); //Create new youtube account!

            ISubscriber Joey = new User();
            ISubscriber Alex = new User();
            ISubscriber Gai = new Moderator();

            Youtube.Subscribe(Joey);
            Youtube.Subscribe(Alex);
            Youtube.Subscribe(Gai);

            Youtube.NotifySubscribers(); //I upload a new video!

            Console.WriteLine("Alex unsubscribed");
            Youtube.Unsubscribe(Alex);

            Youtube.NotifySubscribers();
            Console.Read();
        }
    }
}
