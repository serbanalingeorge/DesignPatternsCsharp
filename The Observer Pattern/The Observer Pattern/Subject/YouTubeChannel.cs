using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Observer_Pattern.Observer;

namespace The_Observer_Pattern.Subject
{
    public class YouTubeChannel
    {
        private IList<ISubscriber> subscribers = new List<ISubscriber>();
        public void Subscribe(ISubscriber s)
        {
            subscribers.Add(s);
        }

        public void Unsubscribe(ISubscriber s)
        {
            subscribers.Remove(s);
        }

        public void NotifySubscribers()
        {
            foreach (ISubscriber s in subscribers)
            {
                s.Notifty();
            }
        }
    }
}
