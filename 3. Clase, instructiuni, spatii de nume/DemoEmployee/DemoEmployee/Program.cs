using System;

namespace DemoEmployee
{
    class Employee
    {
        public String Name; // acces public pe camp pentru simplificarea exemplului
        public decimal Salary; // idem sus
    }
    class Demo
    {
        public static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Name = "Cirlan";
            e.Salary = 300M;
            Console.WriteLine("inainte de apel: nume={0}, salary={1}", e.Name, e.Salary);
            f(e);
            Console.WriteLine("dupa apel: nume={0}, salary={1}", e.Name, e.Salary);
            f(e);

        }
        private static void f(Employee emp)
        {
            emp.Salary = 100M;
            emp.Name = "Ionescu";
        }
    }
}
