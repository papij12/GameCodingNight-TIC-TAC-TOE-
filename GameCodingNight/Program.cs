using System;

namespace GameCodingNight
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int move = 0;
            string x = "X";
            string o = "O";
            int i;
            //int next = 0;
         string[] p = new string[9] { " ", " ", " ", " ", " ", " ", " ", " ", " "};
            Console.WriteLine("Welcome to game night three");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Tic-Tac-Toe\n");
            Console.WriteLine("choose your player : 1 or 2");
            try
            {
                i = int.Parse(Console.ReadLine());
                if (i != 1 && i != 2)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid option");
                }
                if(i == 1)
                {
                    Console.Clear();
                    Console.WriteLine(" Welcome Player 1 : X");
            
                }
                   
                if (i== 2)
                {
                    Console.Clear();
                    Console.WriteLine("Welcome Player 2 : O");
                   
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Clear();
            Console.WriteLine("new game\n");

            Console.WriteLine($" { p[0]} | {p[1]} | {p[2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {p[3]} | {p[4]} | {p[5]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {p[6]} | {p[7]} | {p[8]} ");
            Console.WriteLine();

            do
            {
                if(count % 2 == 0)
                {
                    try
                    {
                        Console.WriteLine("Player 2 It's you time");
                         move = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    try
                    {
                        Console.WriteLine("Player 1 It's you time");
                        move = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                switch (move)
                {
                    case 1:
                        if (count % 2 == 0)
                        {
                            if (p[0] == " ")
                            {
                                p[0] = x;
                                Console.WriteLine();
                                Console.WriteLine($" { p[0]} | {p[1]} | {p[2]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[3]} | {p[4]} | {p[5]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[6]} | {p[7]} | {p[8]} ");
                                Console.WriteLine();
                                count++;
                            }
                            else
                                Console.WriteLine("Wrong move");
                        }
                        else
                        {
                            if (p[0] == " ")
                            {
                                p[0] = o;
                                Console.WriteLine();
                                Console.WriteLine($" { p[0]} | {p[1]} | {p[2]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[3]} | {p[4]} | {p[5]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[6]} | {p[7]} | {p[8]} ");
                                Console.WriteLine();
                                count++;
                            }
                            else
                                Console.WriteLine("Wrong move");
                        }
                            break;

                    case 2:
                        if (count % 2 == 0)
                        {
                            if (p[1] == " ")
                            {
                                p[1] = x;
                                Console.WriteLine();
                                Console.WriteLine($" { p[0]} | {p[1]} | {p[2]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[3]} | {p[4]} | {p[5]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[6]} | {p[7]} | {p[8]} ");
                                Console.WriteLine();
                                count++;
                            }
                            else
                                Console.WriteLine("Wrong move");
                        }
                        else
                        {
                           if (p[1] == " ")
                            {
                                p[1] = o;
                                Console.WriteLine();
                                Console.WriteLine($" { p[0]} | {p[1]} | {p[2]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[3]} | {p[4]} | {p[5]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[6]} | {p[7]} | {p[8]} ");
                                Console.WriteLine();
                                count++;
                            }
                            else
                                Console.WriteLine("Wrong move");
                        }
                        break;

                    case 3:
                        if (count % 2 == 0)
                        {
                            if (p[2] == " ")
                            {
                                p[2] = x;
                                Console.WriteLine();
                                Console.WriteLine($" { p[0]} | {p[1]} | {p[2]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[3]} | {p[4]} | {p[5]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[6]} | {p[7]} | {p[8]} ");
                                Console.WriteLine();
                                count++;
                            }
                            else
                                Console.WriteLine("Wrong move");
                        }
                        else
                        {
                            if (p[2] == " ")
                            {
                                p[2] = o;
                                Console.WriteLine();
                                Console.WriteLine($" { p[0]} | {p[1]} | {p[2]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[3]} | {p[4]} | {p[5]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[6]} | {p[7]} | {p[8]} ");
                                Console.WriteLine();
                                count++;
                            }
                            else
                                Console.WriteLine("Wrong move");
                        }
                        break;

                    case 4:
                        if (count % 2 == 0)
                        {
                            if (p[3] == " ")
                            {
                                p[3] = x;
                                Console.WriteLine();
                                Console.WriteLine($" { p[0]} | {p[1]} | {p[2]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[3]} | {p[4]} | {p[5]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[6]} | {p[7]} | {p[8]} ");
                                Console.WriteLine();
                                count++;
                            }
                            else
                                Console.WriteLine("Wrong move");
                        }
                        else
                        {
                            if (p[3] == " ")
                            {
                                p[3] = o;
                                Console.WriteLine();
                                Console.WriteLine($" { p[0]} | {p[1]} | {p[2]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[3]} | {p[4]} | {p[5]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[6]} | {p[7]} | {p[8]} ");
                                Console.WriteLine();
                                count++;
                            }
                            else
                                Console.WriteLine("Wrong move");
                        }
                        break;

                    case 5:
                        if (count % 2 == 0)
                        {
                            if (p[4] == " ")
                            {
                                p[4] = x;
                                Console.WriteLine();
                                Console.WriteLine($" { p[0]} | {p[1]} | {p[2]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[3]} | {p[4]} | {p[5]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[6]} | {p[7]} | {p[8]} ");
                                Console.WriteLine();
                                count++;
                            }
                            else
                                Console.WriteLine("Wrong move");
                        }
                        else
                        {
                            if (p[4] == " ")
                            {
                                p[4] = o;
                                Console.WriteLine();
                                Console.WriteLine($" { p[0]} | {p[1]} | {p[2]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[3]} | {p[4]} | {p[5]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[6]} | {p[7]} | {p[8]} ");
                                Console.WriteLine();
                                count++;
                            }
                            else
                                Console.WriteLine("Wrong move");

                        }
                        break;

                    case 6:
                        if (count % 2 == 0)
                        {
                            if (p[5] == " ")
                            {
                                p[5] = x;
                                Console.WriteLine();
                                Console.WriteLine($" { p[0]} | {p[1]} | {p[2]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[3]} | {p[4]} | {p[5]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[6]} | {p[7]} | {p[8]} ");
                                Console.WriteLine();
                                count++;
                            }
                            else
                                Console.WriteLine("Wrong move");
                        }
                        else
                        {
                            if (p[5] == " ")
                            {
                                p[5] = o;
                                Console.WriteLine();
                                Console.WriteLine($" { p[0]} | {p[1]} | {p[2]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[3]} | {p[4]} | {p[5]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[6]} | {p[7]} | {p[8]} ");
                                Console.WriteLine();
                                count++;
                            }
                            else
                                Console.WriteLine("Wrong move");

                        }
                        break;

                    case 7:
                        if (count % 2 == 0)
                        {
                            if (p[6] == " ")
                            {
                                p[6] = x;
                                Console.WriteLine();
                                Console.WriteLine($" { p[0]} | {p[1]} | {p[2]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[3]} | {p[4]} | {p[5]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[6]} | {p[7]} | {p[8]} ");
                                Console.WriteLine();
                                count++;
                            }
                            else
                                Console.WriteLine("Wrong move");
                        }
                        else
                        {
                            if (p[6] == " ")
                            {
                                p[6] = o;
                                Console.WriteLine();
                                Console.WriteLine($" { p[0]} | {p[1]} | {p[2]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[3]} | {p[4]} | {p[5]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[6]} | {p[7]} | {p[8]} ");
                                Console.WriteLine();
                                count++;
                            }
                            else
                                Console.WriteLine("Wrong move");

                        }
                        break;

                    case 8:
                        if (count % 2 == 0)
                        {
                            if (p[7] == " ")
                            {
                                p[7] = x;
                                Console.WriteLine();
                                Console.WriteLine($" { p[0]} | {p[1]} | {p[2]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[3]} | {p[4]} | {p[5]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[6]} | {p[7]} | {p[8]} ");
                                Console.WriteLine();
                                count++;
                            }
                            else
                                Console.WriteLine("Wrong move");
                        }
                        else
                        {
                            if (p[7] == " ")
                            {
                                p[7] = o;
                                Console.WriteLine();
                                Console.WriteLine($" { p[0]} | {p[1]} | {p[2]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[3]} | {p[4]} | {p[5]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[6]} | {p[7]} | {p[8]} ");
                                Console.WriteLine();
                                count++;
                            }
                            else
                                Console.WriteLine("Wrong move");

                        }
                        break;

                    case 9:
                        if (count % 2 == 0)
                        {
                            if (p[8] == " ")
                            {
                                p[8] = x;
                                Console.WriteLine();
                                Console.WriteLine($" { p[0]} | {p[1]} | {p[2]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[3]} | {p[4]} | {p[5]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[6]} | {p[7]} | {p[8]} ");
                                Console.WriteLine();
                                count++;
                            }
                            else
                                Console.WriteLine("Wrong move");
                        }
                        else
                        {
                            if (p[8] == " ")
                            {
                                p[8] = o;
                                Console.WriteLine();
                                Console.WriteLine($" { p[0]} | {p[1]} | {p[2]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[3]} | {p[4]} | {p[5]} ");
                                Console.WriteLine("---+---+---");
                                Console.WriteLine($" {p[6]} | {p[7]} | {p[8]} ");
                                Console.WriteLine();
                                count++;
                            }
                            else
                                Console.WriteLine("Wrong move");

                        }
                        break;

                     default:
                        Console.WriteLine("Wrong move");
                        break;
                }
                

            } while (count <= 9);
            Console.WriteLine("GAME OVER!!");
        } 
    }
}
