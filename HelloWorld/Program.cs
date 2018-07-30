using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World this is test 2#");
            Console.WriteLine("Press 1 for goof, press 2 for poof, Tab for toatal poofs and goofs pressed and, Escape for stop!!!");
            bool runMenu = true;
            bool stooop = false;
            int poofCount = 0;
            int goofCount = 0;
            AfrikaCharacter stud = new AfrikaCharacter();

            

            while (runMenu)
            {
                int totalCount = goofCount + poofCount;
                Console.WriteLine();
                Console.WriteLine("Stud's health is: " + stud.GetHealth());

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (stooop == true)
                {
                    if (keyInfo.Key == ConsoleKey.D1)
                    {
                        goofCount++;
                        Console.WriteLine("GOOF pressed: " + goofCount + " times");
                        stud.DecreaseHealth(5);
                    }
                    else if (keyInfo.Key == ConsoleKey.D2)
                    {
                        poofCount = poofCount + 1;
                        Console.WriteLine("POOF pressed: " + poofCount + " times");
                        stud.IncreaseHealth(5);
                    }
                    else if (keyInfo.Key == ConsoleKey.Escape)
                    {
                        runMenu = false;

                        Console.WriteLine("stoping program");
                    }
                    else if (keyInfo.Key == ConsoleKey.Tab)
                    {
                        Console.WriteLine("total count is " + totalCount + " presses");
                    }
                    else { Console.WriteLine("Not an option!"); }
                }
                if ( stud.GetHealth() == 0 )  
                {
                   Console.WriteLine ("stud is dead the end goodbye");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    
                }
                if (totalCount == 400)
                {
                    stooop = true;
                    Console.WriteLine("you have hit poof and goof so many times stud is");
                     Console.WriteLine(" probubly dead bye now please hit tab to see");
                    Console.WriteLine(" how much you have hit 1 and 2 then when you are"); 
                    Console.WriteLine(" done press enter enjoy P.S. stud hates you >_<");
                }
            }
        }
    }

    public class AfrikaCharacter
    {
        private int health = 1000;

        public void IncreaseHealth(int value)
        {
            health = health + value;
            if (health > 100)
            {
                health = 100;
            }
        }

        public void DecreaseHealth(int value)
        {
            health = health - value;
            if (health < 0)
            {
                health = 0;
            }
        }

        public int GetHealth()
        {
            return health;
        }
    }
}
