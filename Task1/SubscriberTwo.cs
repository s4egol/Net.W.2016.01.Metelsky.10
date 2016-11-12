using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class SubscriberTwo
    {
        public SubscriberTwo()
        {
            
        }

        public SubscriberTwo(TimeManager timeManager)
        {
            Register(timeManager);
        }
        public void Register(TimeManager timeManager)
        {
            timeManager.TimeIsOver += SubscriberMsg;
        }

        public void Unregister(TimeManager timeManager)
        {
            timeManager.TimeIsOver -= SubscriberMsg;
        }

        private void SubscriberMsg(Object sender, ImitationWatchEventArgs e)
        {
            Console.WriteLine($"I am SubscriberTwo and I waited an answer for {e.Timer} seconds!");
        }
    }
}
