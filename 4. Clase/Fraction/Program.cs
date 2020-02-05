using System;

namespace Fraction
{
    public class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
        {
            Console.WriteLine("In constructor fraction(int, int)");
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public Fraction(int wholeNumber)
        {
            Console.WriteLine("In constructor fraction(int)");
            numerator = wholeNumber;
            denominator = 1;
        }

        public static implicit operator Fraction(int theInt)
        {
            Console.WriteLine("In conversie implicita la Fraction");
            return new Fraction(theInt);
        }

        public static explicit operator int(Fraction theFraction)
        {
            Console.WriteLine("In conversie explicita la int");
            return theFraction.numerator / theFraction.denominator;
        }

        public static bool operator==(Fraction lhs, Fraction rhs)
        {
            Console.WriteLine("In operator =");
            if(lhs.denominator * rhs.numerator == rhs.denominator*lhs.numerator)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Fraction lhs, Fraction rhs)
        {
            Console.WriteLine("In operator !=");
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            Console.WriteLine("In metoda Equals");
            if(! (obj is Fraction))
            {
                return false;
            }
            return this == (Fraction) obj;
        }

        public static Fraction operator+(Fraction lhs, Fraction rhs)
        {
            Console.WriteLine("In operator");
            // 1/2 + 3/4 == (1*4) + (3*2) / (2*4) == 10/8
            int firstProduct = lhs.numerator * rhs.denominator;
            int secondProduct = rhs.numerator * lhs.denominator;
            return new Fraction(
                firstProduct + secondProduct, lhs.denominator * rhs.denominator);
        }

        public override string ToString()
        {
            String s = numerator.ToString() + "/" + denominator.ToString();
            return s;
        }
    }

    public  class Demo
    {
        static void Main()
        {
            Fraction f1 = new Fraction(3, 4);
            Console.WriteLine("f1: {0}", f1.ToString());
            Fraction f2 = new Fraction(2, 4);
            Console.WriteLine("f2: {0}", f2.ToString());
            Fraction f3 = f1 + f2;
            Console.WriteLine("f1+f2=f3:  {0}", f3.ToString());
            Fraction f4 = f3 + 5;
            // se apeleaza conversia implicita  de la int la Fraction
            // apoi se foloseste supraincarcarea operatorului +
            Console.WriteLine("f3 + 5 = f4: {0}", f4.ToString());
            Fraction f5 = new Fraction(2, 4);
            if(f5 == f2)
            {
                Console.WriteLine("f5: {0} = f2: {1}", f5.ToString(), f2.ToString());
            }
            Fraction f6 = (int)f5;
            Console.WriteLine("f6: {0}", f6.ToString());
        }
    }
}
