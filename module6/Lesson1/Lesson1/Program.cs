using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double[] scores = new double[4]; // Here is my example of Arrays
            Console.WriteLine("Enter the 4 test scores:");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0}>", i + 1);
                try // Here is my example of Try-Catch
                {
                    double temp = double.Parse(Console.ReadLine());
                    if (IsScoreValid(temp)) // Here is my example of Methods
                    {
                        scores[i] = temp; // Here is my example of Arrays
                    }
                    else
                    {
                        Console.WriteLine("Invalid score. Try again.");
                        i--;
                    }
                }
                catch // Here is my example of Try-Catch
                {
                    Console.WriteLine("Invalid entry. Try again.");
                    i--;
                }
            }

            Console.WriteLine("Average = {0}", AverageScore());

            Console.WriteLine("I couldn't figure out a good recursion example for test scores.");
            Console.WriteLine("So I just did the factorial example in the Quiz.");
            Console.WriteLine("Factor of 5 is {0}", Fact(5));

            Console.ReadLine();


            double AverageScore()
            {
                double average;
                double sum = 0;
                foreach(double score in scores)
                {
                    sum += score;
                }
                average = sum / scores.Length;
                return average;
            }

            bool IsScoreValid(double score) // Here is my example of Methods
            {
                bool valid = false;
                if ((score <= 100.0)&&(score >= 0.0)) {
                    valid = true;
                }
                return valid;
            }

            int Fact(int n)// Here is my example of Recursion
            {
                int result;
                if (n == 1) return 1;
                result = Fact(n - 1) * n;
                return result;
            }
        }
    }
}
