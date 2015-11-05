using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    public class TimerManager
    {
        public event EventHandler timeOff;

        protected virtual void OnTimeOff()
        {
            EventHandler temp = Interlocked.CompareExchange(ref timeOff, null, null);
            if (temp != null)
                temp(this, EventArgs.Empty);
        }

        public void Start(int milliseconds)
        {
            Thread.Sleep(milliseconds);
            OnTimeOff();
        }
    }
}
