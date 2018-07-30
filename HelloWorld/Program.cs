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
            Console.WriteLine("Press 1 for goof, press 2 for poof:");
            bool runMenu = true;

            while (runMenu)
            {
               
                Console.WriteLine();
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("GOOF!!!");
                }
                else if (keyInfo.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("POOF!!!");
                } else if (keyInfo.Key == ConsoleKey.Enter) {
                    runMenu = false;
                }
                else
                {
                    Console.WriteLine("Not an option!");
                }
            }
        }
    }
}
