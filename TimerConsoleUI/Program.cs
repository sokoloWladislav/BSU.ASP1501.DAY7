using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer;

namespace TimerConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            TimerManager timer = new TimerManager();
            AlarmClock alarmClock = new AlarmClock(timer);
            Finisher finisher = new Finisher(timer);

            timer.Start(5000);

            alarmClock.Unregister(timer);

            timer.Start(2000);
            Console.ReadKey();
        }
    }
}
