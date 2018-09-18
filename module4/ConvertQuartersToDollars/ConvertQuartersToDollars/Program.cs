using System;

namespace ConvertQuartersToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many quarters? ");
            int quarters = int.Parse(Console.ReadLine());
            ConvertToDollars(quarters);
            Console.ReadLine();
        }

        public static void ConvertToDollars(int quarters)
        {
            Console.WriteLine("You have {0} dollars and {1} cents.", quarters / 4, (quarters % 4) * 25);
        }
    }
}
