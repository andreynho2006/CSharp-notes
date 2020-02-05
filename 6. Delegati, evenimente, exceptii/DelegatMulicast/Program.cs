using System;

namespace DelegatMulicast
{

    // declaratie de delegat multicast
    public delegate void StringDelegate(string s);

    public class MyImplementingClass
    {
        public static void WriteString(string s)
        {
            Console.WriteLine("Writing string {0}", s);
        }

        public static void LogString(string s)
        {
            Console.WriteLine("Logging string {0}", s);
        }

        public static void TransmitString(string s)
        {
            Console.WriteLine("Transmitting string {0}", s);
        }
    }


    class Demo
    {  
        public static void Main(string[] args)
        {
            // defineste 3 obiecte delegat
            StringDelegate writer, logger, transmitter;
            //defineste alt delegat care va actiona ca un delegat multicast
            StringDelegate myMulticastingDelegate;
            // Instantiaza primii 3 delegati dand metodele ce se vor incapsula
            writer = MyImplementingClass.WriteString;
            logger = MyImplementingClass.LogString;
            transmitter = MyImplementingClass.TransmitString;
            //invoca metoda delegat writer
            writer("String passed to writer");
            //invoca metoda logger
            logger("String passed to Logger");
            //invaca metoda delegat transmitter
            transmitter("String passed to Transmiter");
            // anunta utilizatorul ca va combina 2 delegati
            Console.WriteLine("myMulticastDelegate = writer + logger");
            // combina 2 delegati , rezultatul este atasat lui myMulticastingdelegate
            myMulticastingDelegate = writer + logger;
            // apeleaza myMulticastDelegate, de fapt vor fi chemate cele 2 metode
            myMulticastingDelegate("First string passed to Collector");
            // anunta utilizatorul ca se va adauga un al 3 lea delegat
            Console.WriteLine("myMulticastDelegate += transmitter");
            // adauga al 3 lea delegat
            myMulticastingDelegate += transmitter;
            // invoca cele 3 metode delegate
            myMulticastingDelegate("Second string passed to Collector");
            // anunta utilizatorul ca se va scoate delegatul Logger
            Console.WriteLine("myMulticastingDelegate -= legger");
            //scoate delegatul Logger
            myMulticastingDelegate -= logger;
            // invoca cele 2 metode delegat ramase
            myMulticastingDelegate("Third string passed to Collector");
        }
    }
}
