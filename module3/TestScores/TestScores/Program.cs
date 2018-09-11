using System;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            double testScore = 0;
            bool check = true;
            int counter = 0;
            do
            {
                Console.Write("Enter a test score (999 to quit): ");
                double tempValue = Convert.ToDouble(Console.ReadLine());
                if ( (tempValue >=0) && (tempValue <=100) ) {
                    testScore += tempValue;
                    counter++;
                }
                else if (tempValue == 999)
                {
                    check = false;
                }
                else
                {
                    Console.WriteLine("Invalid value. Try again.");
                }
            }
            while (check);

            Console.WriteLine("{0} test scores entered. {1} is the average.", counter, testScore / counter);
            Console.ReadLine();
        }
    }
}
