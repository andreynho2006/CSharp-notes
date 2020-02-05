using System;

namespace TemperatureConverter
{
    public static class TemperatureConverter
    {
        public static double CelsiusToFahrenheit(string temperatureCelsius)
        {
            double celsius = Double.Parse(temperatureCelsius);
            double fahrenheit = celsius * 1.6 + 32;
            return fahrenheit;
        }

        public static double FahrenheitToCelsius(string temperatureFahrenheit)
        {
            double fahrenheit = Double.Parse(temperatureFahrenheit);
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
    }

    class DemoTemperatureConverter
    {
        static void Main()
        {
            Console.WriteLine("Optiuni");
            Console.WriteLine("1.   Celsius -> Fahrenheit");
            Console.WriteLine("2.   Fahrenheit -> Celsius");
            Console.WriteLine("Alegere:");
            string selection = Console.ReadLine();
            double c, f = 0;
            switch(selection)
            {
                case "1":
                    Console.WriteLine("Temperatura Celsius");
                    f = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine());
                    Console.WriteLine("Temperatura in Fahrenheit: {0}", f);
                    break;
                case "2":
                    Console.WriteLine("Temperatura Fahrenheit");
                    c = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
                    Console.WriteLine("Temperatura in Celsius: {0}", c);
                    break;
            }
        }
    }
}
