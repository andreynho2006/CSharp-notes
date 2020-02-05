using System;
using System.IO;

namespace InstructiuniCSharp
{
    class MainClass
    {
    }

    class DemoLabel
    {
        private int f(int x)
        {
            if (x >= 0) goto myLabel;
            x = -x;
            //Console.WriteLine(x);
            myLabel: return x;
        }

        public static void Main(string[] args)
        {
            DemoLabel dl = new DemoLabel();
            dl.f(-14);

            using( TextWriter w = File.CreateText("log.txt"))
            {
                w.WriteLine("This is line 1");
                w.WriteLine("This is line 2");
            }

            using ( myResources resources = new myResources())
            {
                Console.WriteLine("In using");
            }

        }
    }

    class myResources : IDisposable // clasa myResources implementeaza interfata IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("MyResources.Dispose()");
        }
    }
}
