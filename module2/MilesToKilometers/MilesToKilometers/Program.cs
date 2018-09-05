using System;

namespace MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            const double kiloInMile = 1.6;
            double miles = 4;
            Console.WriteLine("{0} Miles is the same as {1} Kilometers", miles, miles * kiloInMile);
            Console.ReadLine();
        }
    }
}
