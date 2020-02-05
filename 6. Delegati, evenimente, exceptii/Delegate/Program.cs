using System;

namespace Delegate
{
    public delegate int MyDelegate(int x, int y);

    class Demo
    {
        public int Computation(int a, int b, MyDelegate myDelegate)
        {
            return myDelegate(a, b);
        }

        public int Sum(int x, int y) // se respecta semnatura data de MyDelegate
        {
            return x + y;
        }

        public int Difference(int x, int y) // se respecta semnatura data de MyDelegate
        {
            return x - y;
        }

        public static void Main(string[] args)
        {
            Demo demo = new Demo();
            MyDelegate del = demo.Sum;
            Console.WriteLine("Adunare: {0}", demo.Computation(3, 4, del).ToString());
            del = demo.Difference;
            Console.WriteLine("Scader: {0}", demo.Computation(3, 4, del).ToString());
        }
    }
}
