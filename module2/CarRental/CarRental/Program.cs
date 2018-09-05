using System;

namespace CarRental
{
    class Program
    {
        static void Main(string[] args)
        {
            const double dailyCost = 20;
            const double perMileCost = .25;
            double milesDriven = 10;
            double daysRented = 4;
            double totalCost = (daysRented * dailyCost) + (milesDriven * perMileCost);
            Console.WriteLine("{0} is the total cost", totalCost.ToString("C2"));
            Console.ReadLine();
        }
    }
}
