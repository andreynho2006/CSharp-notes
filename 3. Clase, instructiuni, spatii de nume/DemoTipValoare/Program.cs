using System;

namespace DemoTipValoare
{
    class DemoTipValoare
    {
        static void f(int b)
        {

            Console.WriteLine("La intrare in f: {0}", b);
            ++b;
            Console.WriteLine("La iesire din f: {0}", b);
        }

        static void Main()
        {
            int a = 100;

            Console.WriteLine("Inainte de intrarea in f: {0}", a);
            f( a ) ;
            Console.WriteLine("Dupa executarea lui f: {0}", a);
        }
    }
}
