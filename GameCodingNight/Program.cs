using System;

namespace GameCodingNight
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int option = 1;
            bool decision=true;
            string g = " ";
           
                Console.Clear();
                Console.WriteLine("Welcome to game night three");
                Console.ReadLine();
            do
            {
                Console.Clear();
                Console.WriteLine("Tic-Tac-Toe\n");
                Console.WriteLine($"1.{Menu.New_game}\n2.{Menu.About_The_Author}\n3.{Menu.Exit}");
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                switch (option)
                {
                    case 1:
                        Game.ProcessMenuGame(Menu.New_game);
                        break;
                    case 2:
                        Game.ProcessMenuGame(Menu.About_The_Author);
                        break;
                    case 3:
                        Game.ProcessMenuGame(Menu.Exit);
                            do
                            {
                            Console.WriteLine("Press y to end the game or n to go back to menu");
                            g = Console.ReadLine();
                            if (g != "y" && g != "n")
                            {
                                Console.WriteLine("wrong input");
                            }
                            else
                                decision = false;

                            } while (decision);
                        break;
                    default:
                        Console.WriteLine("Wrong Option");
                        break;
                }
            } while (option == 1 || option == 2 || g =="n");
            Console.Clear();
            Console.WriteLine("Clossing the app...");
            Console.ReadLine();
        }
    }
}
