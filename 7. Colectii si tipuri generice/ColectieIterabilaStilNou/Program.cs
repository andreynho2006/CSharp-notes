using System;
using System.Collections;

namespace ColectieIterabilaStilNou
{
    class Demo
    {
        static IEnumerable Numere()
        {
            Console.WriteLine("In metoda Numere: returnare 1");
            yield return 1;
            Console.WriteLine("In metoda Numere: returnare 2");
            yield return 2;
            Console.WriteLine("In metoda Numere: returnare 3");
            yield return 3;
        }
        public static void Main(string[] args)
        {
            foreach(int valoare in Numere())
            {
                Console.WriteLine("In main: {0}", valoare.ToString());
            }    
        }
    }
}
