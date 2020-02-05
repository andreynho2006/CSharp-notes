using System;

namespace MyVector
{
    class MyVector
    {
        private double[] v;
        public MyVector( int length )
        {
            v = new double[length];
        }
        public int Length
        {
            get
            {
                return v.Length;
            }
        }
        public double this[int index]
        {
            get
            {
                return v[index];
            }
            set
            {
                v[index] = value;
            }
        }
    }

    class Demo
    {
        static void Main()
        {
            MyVector v = new MyVector(10);
            v[0] = 0;
            v[1] = 1;
            for( int i=2; i<v.Length; i++)
            {
                v[i] = v[i - 1] + v[i - 2];
            }
            for( int i=0; i<v.Length; i++)
            {
                Console.WriteLine("v[{0}]={1}", i.ToString(), v[i].ToString());
            }
        }
    }
}
