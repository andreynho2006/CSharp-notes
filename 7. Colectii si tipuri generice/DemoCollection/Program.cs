using System;
using System.Collections;
using System.Text;

namespace DemoCollection
{
    class Program
    {
        static IEnumerable Patrate(int prag)
        {
            for(int i = 1; i <= prag; i++)
            {
                yield return i * i;
            }
        }
        public static void Main(string[] args)
        {
            foreach(int iterare in Patrate(10))
            {
                Console.WriteLine(iterare.ToString());
            }
        }
    }
}
