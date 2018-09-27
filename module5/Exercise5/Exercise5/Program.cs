using System;

namespace Exercise5
{
    class HockeyPlayer
    {
        static void Main(string[] args)
        {
            Hockey player1 = new Hockey();
            player1.PlayerName = "Some Player";
            player1.JerseyNumber = 7;
            player1.GoalsScored = 5;

            player1.DisplayStats();
            Console.ReadLine();
        }
    }

    class Hockey
    {
        public Hockey()
        {
            Console.WriteLine("Hello from Constructor");
        }

        public string PlayerName { get; set; }
        public int JerseyNumber { get; set; }
        public int GoalsScored { get; set; }

        public void DisplayStats()
        {
            Console.WriteLine("Name {0} Jersey {1} Goals {2}", PlayerName, JerseyNumber, GoalsScored);
        }
    }
}
