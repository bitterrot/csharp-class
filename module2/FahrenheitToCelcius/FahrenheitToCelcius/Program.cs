using System;

namespace FahrenheitToCelcius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Temp in Fahrenheit: ");
            double userValue = Convert.ToDouble(Console.ReadLine());
            double tempInCelcius = (userValue - 32) * 5 / 9;
            Console.WriteLine("{0} in Fahrenheit is {1} in Celcius", userValue, tempInCelcius);
            Console.ReadLine();
        }
    }
}
