using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task1UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeManager = new TimeManager();
            var subscriber1 = new SubscriberOne();
            subscriber1.Register(timeManager);
            var subscriber2 = new SubscriberTwo(timeManager);

            timeManager.SimulateTimer(10);
            Console.ReadKey();
        }
    }
}
