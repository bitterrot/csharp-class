using System;

namespace OtherExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            bool battle = true;
            Console.Write("Enter Player Name: ");
            Player character = new Player(Console.ReadLine());
            Monster beast = new Monster(10);
            Console.WriteLine("You encounter a monster.");
            do
            {
                Console.WriteLine("Monster Attacks!");
                character.TakeDamage(beast.Attack);
                Console.WriteLine("What attack are you using?");
                Console.WriteLine("1. Basic");
                Console.WriteLine("2. Major");
                Console.Write("Selection: ");
                int attack = int.Parse(Console.ReadLine());
                switch (attack)
                {
                    case 1:
                        beast.TakeDamage(character.BasicAttack);
                        break;
                    case 2:
                        beast.TakeDamage(character.MajorAttack);
                        break;
                    default:
                        Console.WriteLine("Not an attack. Swing and a miss.");
                        break;
                }

                if (character.Health <= 0)
                {
                    Console.WriteLine("You have died.");
                    Console.ReadLine();
                    battle = false;
                }
                if (beast.Health <= 0)
                {
                    Console.WriteLine("The monster has died.");
                    Console.ReadLine();
                    battle = false;
                }
            } while (battle);
        }
    }

    class Player
    {
        public Player(string name)
        {
            Name = name;
            Health = 100;
            BasicAttack = 10;
            MajorAttack = 25;
        }

        public string Name { get; set; }
        public int Health { get; set; }
        public int BasicAttack { get; set; }
        public int MajorAttack { get; set; }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine("You take {0} damage.", damage);
            Console.WriteLine("Current Health: {0}", Health);
        }
    }

    class Monster
    {
        public Monster(int attack)
        {
            Health = 60;
            Attack = attack;
        }
        public int Health { get; set; }
        public int Attack { get; set; }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine("You deal {0} damage.", damage);
            Console.WriteLine("Monster's Health: {0}", Health);
        }
    }
}
