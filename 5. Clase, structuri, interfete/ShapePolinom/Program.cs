using System;

namespace ShapePolinom
{
    class Shape
    {
        public virtual void Draw()
        {
            System.Console.WriteLine("Shape.draw()");
        }
    }

    class Polinom: Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Polinom.draw()");
            // desenarea s-ar face prin GDI+
        }
    }

    class Demo
    {
        static void Main()
        {
            Polinom p = new Polinom();
            Shape s = p; // conversie la o clasa parinte
            p.Draw();
            s.Draw();
        }
    }
}
