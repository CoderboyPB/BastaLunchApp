using System;

namespace BastaLunchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basta! 2019!");
            
            var lunchLoader = new LunchItem();
            Console.WriteLine("Press 'v' for vegi, and any key for meat");
            Console.WriteLine();
            var key = Console.ReadKey();
            if(key.Key == ConsoleKey.V)
            {
                lunchLoader.PrintVegi();
            }
            else
            {
                lunchLoader.PrintMeat();
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Press any key to exit");

            _ = Console.ReadKey();
        }
    }
}
