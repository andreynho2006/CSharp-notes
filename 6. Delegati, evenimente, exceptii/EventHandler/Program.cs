using System;
using System.Threading;

namespace EventHandler
{
    public class TimeInfoEventArgs : EventArgs
    {
        public TimeInfoEventArgs(int hour, int minute, int second)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }
        public readonly int Hour;
        public readonly int Minute;
        public readonly int Second;

    }

    //clasa care publica un eveniment: OnSecondChange
    // clasele care se aboneaza vor subscrie la acest eveniment
    public class Clock
    {
        // delegatul pe care abonatii trebuie sa il implementeze
        public delegate void SecondChangeHandler(object clock, TimeInfoEventArgs timeInformation);
        // evenimentul ce se publica
        public event SecondChangeHandler OnSecondChange;
        // ceasul este pornit si merge la infinit
        // va declansa un eveniment pentru fiecare secunda trecuta
        public void Run()
        {
            DateTime now = DateTime.Now;
            this.Second = now.Second;
            this.Minute = now.Minute;
            this.Hour = now.Hour;
            for (; ; )
            {
                //dormi 10 milisecunde
                Thread.Sleep(10);
                //obtine timpul curent
                DateTime dt = DateTime.Now;
                // daca timpul s-a schimbat cu o secunda atunci notifica abonatii
                if (dt.Second != Second) // second este camd al clasei Clock
                {
                    // creaza obiect TimeInfoEventArgs ce va fi trimis abonatilor
                    TimeInfoEventArgs timeInformation = new TimeInfoEventArgs(dt.Hour, dt.Minute, dt.Second);
                    //daca cineva este abonat, atunci anunta-l
                    if (OnSecondChange != null)
                    {
                        OnSecondChange(this, timeInformation);
                    }
                }
                // modifica starea curenta
                this.Second = now.Second;
                this.Minute = now.Minute;
                this.Hour = now.Hour;
            }
        }
        public int Hour;
        public int Minute;
        public int Second;
    }
    // un observator(abonat)
    // DisplayClock va subscrie la evenimentul lui Clock
    // DisplayClock va afisa timpul curent
    public class DisplayClock
    {
        // dandu-se un eveniment clock, va subscrie
        public void Subscribe(Clock theClock)
        {
            theClock.OnSecondChange += new Clock.SecondChangeHandler(timeHasChanged);
            // mai pe scurt se poate scrie
            // theClock.OnSecondChange += timeHasChanged;
        }
        // handlerul de eveniment de pe partea clasei DisplayClock
        void timeHasChanged(object clock, TimeInfoEventArgs ti)
        {
            Console.WriteLine("Current time: {0}:{1}:{2}", ti.Hour.ToString(), ti.Minute.ToString(), ti.Second.ToString());
        }
    }

    // un al doilea abonat care ar trebui sa scrie intr-un fisier
    public class LogCurrentTime
    {
        public void Subscribe(Clock theClock)
        {
            theClock.OnSecondChange += new Clock.SecondChangeHandler(writeLogEntry);
            // mai pe scurt se poate scrie
            // theclock.OnSecondChange += writeLogEntry
        }
        // acest handler ar trebui sa scrie intr-un fisier
        // dar va scrie la standard output
        private void writeLogEntry(object theClock, TimeInfoEventArgs ti)
        {
            Console.WriteLine("Logging to file: {0}:{1}:{2}", ti.Hour.ToString(), ti.Minute.ToString(), ti.Second.ToString());
        }
    }

    public class Demo
    {
        static void Main()
        {
            // creeaza un obiect de tip clock
            // acest obiect semnaleaza prin eveniment scurgerea timpului
            // este obiect publisher
            Clock theClock = new Clock();
            // creaaza un obiect DisplayClock care va subscrie la evenimentul obiectului Clock anterior creat
            DisplayClock dc = new DisplayClock();
            dc.Subscribe(theClock);
            // analog se creeaza un obiect de tip LogCurrentTime
            // care va subscrie la acelasi eveniment ca si obiectul DisplayClock
            LogCurrentTime lct = new LogCurrentTime();
            lct.Subscribe(theClock);
            // porneste ceasul
            theClock.Run();
        }
    }
}
