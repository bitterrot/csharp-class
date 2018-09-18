using System;

namespace PaintingEstimate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of wall (in ft.): ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Enter the width of the wall (in ft.): ");
            double width = double.Parse(Console.ReadLine());
            double wallArea = ComputeWallArea(length, width);
            double paintCost = ComputePaintPrice(wallArea);
            double laborCost = ComputeLaborPrice(wallArea);
            Console.WriteLine("The total cost to paint the room is {0:C}", paintCost + laborCost);
            Console.ReadLine();
        }

        public static double ComputeWallArea(double length, double width)
        {
            double area = length * width * 4 - (6 * 4);
            return area;
        }

        public static double ComputePaintPrice(double area)
        {
            double paintCost = area * 1.5;
            return paintCost;
        }

        public static double ComputeLaborPrice(double area)
        {
            double laborCost = area * 6;
            return laborCost;
        }
    }
}
