using System;

namespace Circle
{
    class Circle
    {
        private double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        public double Aria
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
            set
            {
                Radius = Math.Sqrt(value / Math.PI);
            }
        }
    }

    class Demo
    {
        static void Main()
        {
            Circle c = new Circle();
            c.Radius = 10;
            Console.WriteLine("Aria: {0}", c.Aria.ToString());
            c.Aria = 15;
            Console.WriteLine("Radius: {0}", c.Radius.ToString());
        }
    }

    public class Emplyee
    {
        private string name;
        public Emplyee(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get
            {
                return name;
            }
            protected set
            {
                name = value;

            }
        }
    }
}
