using System;

namespace First_Project___Work__Rest__Pay_Rent
{   
    class Program
    {
        static void Main(string[] args)
        {
            Game g1 = new Game();
            bool game = true;
            Console.WriteLine("Would you like to play a game? Y/N");

            while (game)
            {
                var PlayGame = Console.ReadKey(true);
                switch (PlayGame.Key)
                {
                    case ConsoleKey.Y:
                        g1.Run();
                        break;
                    case ConsoleKey.N:
                        game = false;
                        Console.WriteLine("Goodbye!");                       
                        break;                    
                }
            }          
        }  
    }
}
