using System;

namespace ExceptionHandling
{
    public class MyCustomException : ApplicationException
    {
        public MyCustomException(string message, Exception inner):base(message, inner)
        {
        }
    }

    public class Test
    {
        public static void Main()
        {
            Test t = new Test();
            t.TestFunc();
        }
        public void TestFunc()
        {
            try
            {
                DangerousFunc1();
            }
            catch ( MyCustomException e)
            {
                Console.WriteLine("\n{0}", e.Message);
                Console.WriteLine("Retrieving exc eption history...");
                Exception inner = e.InnerException;
                while(inner != null )
                {
                    Console.WriteLine("{0}", inner.Message);
                    inner = inner.InnerException;
                }
            }
        }
        public void DangerousFunc1()
        {
            try
            {
                DangerousFunc2();
            }
            catch(Exception e)
            {
                MyCustomException ex = new MyCustomException("E3 - Custom Exception Situation!", e);
                throw e;
            }
        }
        public void DangerousFunc2()
        {
            try
            {
                DangerousFunc3();
            }
            catch (System.DivideByZeroException e)
            {
                Exception ex = new Exception("E2 - cought divide by 0!", e);
                throw ex;
            }
        }
        public void DangerousFunc3()
        {
            try
            {
                DangerousFunc4();
            }
            catch (System.ArithmeticException)
            {
                throw;
            }
            catch (Exception)
            {
                Console.WriteLine("Exception handled here");
            }
        }
        public void DangerousFunc4()
        {
            throw new DivideByZeroException("E1 - DivideByZero Exception");
        }
    }
}
