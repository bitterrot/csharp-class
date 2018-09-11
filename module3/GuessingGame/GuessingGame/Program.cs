using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 101);
            int numberOfGuesses = 15;
            int[] guesses = new int[numberOfGuesses];
            bool check = true;
            int counter = 0;
            while (check)
            {
                Console.Write("Guess a number between 1 and 100: ");
                guesses[counter] = Convert.ToInt16(Console.ReadLine());

                if (guesses[counter] == number)
                {
                    Console.WriteLine("Correct");
                    check = false;
                }
                else if (guesses[counter] > number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Higher");
                }
                if (numberOfGuesses == counter + 1)
                {
                    Console.WriteLine("No more guesses. The number was {0}.", number);
                    check = false;
                }
                else if (check)
                {
                    counter++;
                }
            }
            Console.Write("Guesses: ");
            for (int i=0;i<=counter;i++)
            {
                Console.Write("{0} ",guesses[i].ToString());
            }

            Console.ReadLine();
        }
    }
}
