using System;

namespace MyClass
{
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Constructor instanta.");
        }
        public MyClass(int value)
        {
            myField = value;
            Console.WriteLine("Constructor instanta.");
        }
        public const int Myconst = 12;
        private int myField = 42;
        public void MyMethod()
        {
            Console.WriteLine("this.MyMethod");
        }
        public int MyProperty
        {
            get
            {
                return myField;
            }
            set
            {
                myField = value;
            }
        }
        public int this[int index]
        {
            get
            {
                return 0;
            }
            set
            {
                Console.WriteLine("this[{0}]={1}", index, value);
            }
        }
        public event EventHandler MyEvent;
        public static MyClass operator+(MyClass a, MyClass b)
        {
            return new MyClass(a.myField + b.myField);
        }
    }

    class Demo
    {
        static void Main()
        {
            MyClass a = new MyClass();
            MyClass b = new MyClass();
            Console.WriteLine("MyConst={0}", MyClass.Myconst);
            //a.Field++// gradul de acces nu permite lucrul direct cu campul
            a.MyMethod();
            a.MyProperty++;
            Console.WriteLine("a.MyProperty={0}", a.MyProperty);
            a[3] = a[1] = a[2];
            Console.WriteLine("a[3]={0}", a[3]);
            a.MyEvent += new EventHandler(MyHandler);
            MyClass c = a + b;
        }

        static void MyHandler(object Sender, EventArgs e)
        {
            Console.WriteLine("Demo MyHandler");
        }

        internal class MyNestedType
        { }
    }
}
