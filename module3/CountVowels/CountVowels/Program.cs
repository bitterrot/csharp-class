using System;

namespace CountVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            string vowels = "aeiou";
            Console.Write("Enter a phrase: ");
            string tempValue = Console.ReadLine();
            int counter = 0;
            for (int i=0;i<tempValue.Length;i++)
            {
                if (vowels.Contains( tempValue.Substring(i, 1).ToLower() ))
                {
                    counter++;
                }
            }
            Console.WriteLine("There are {0} vowels in the phrase '{1}'", counter, tempValue);     
            Console.ReadLine();
        }
    }
}
