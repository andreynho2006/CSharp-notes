using System;

namespace ExceptionDocument
{
    class DivideException
    {
        ///<sumay>
        /// computes a/b
        /// </sumay>
        /// <params name = "a">The numerator.</params>
        /// <params name = "b">The denominator</params>
        /// <returns>a/b if it can be computed</returns>
        /// <exception cref="DivideByZeroException">Cannot divide by zero</exception>
        /// <exception cref="="ArithmeticException">The numerator cannot be zero</exception>
        public double DoDivide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            if (a == 0)
            {
                throw new ArithmeticException("The numerator cannot be zero");
            }
            return a / b;
        }
    }
}
