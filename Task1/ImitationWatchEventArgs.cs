using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    public class ImitationWatchEventArgs : EventArgs
    {
        public int Timer { get; }

        public ImitationWatchEventArgs(int timer)
        {
            if (timer <= 0)
                throw new ArgumentException();

            Timer = timer;
        }

        public void RunTimer()
        {
            int timer = Timer;

            do
            {
                timer--;
                Thread.Sleep(1000);
            }
            while (timer > 0);
        }
    }

    public class TimeManager
    {
        public delegate void ImitationWatchEventHandler(object sender, ImitationWatchEventArgs e);
        public event ImitationWatchEventHandler TimeIsOver;

        private void EndTimer(ImitationWatchEventArgs e)
        {
            ImitationWatchEventHandler alertSubscribers = Volatile.Read(ref TimeIsOver);
            alertSubscribers?.Invoke(this, e);
        }

        public void SimulateTimer(int timer)
        {
            if (timer <= 0)
                throw new ArgumentException();

            ImitationWatchEventArgs e = new ImitationWatchEventArgs(timer);
            e.RunTimer();

            EndTimer(e);
        }
    }

}
