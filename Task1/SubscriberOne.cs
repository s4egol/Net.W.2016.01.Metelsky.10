using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class SubscriberOne
    {
        public SubscriberOne()
        {

        }

        public SubscriberOne(TimeManager timeManager)
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
            Console.WriteLine($"I am SubscriberOne and I waited an answer for {e.Timer} seconds!");
        }
    }
}
