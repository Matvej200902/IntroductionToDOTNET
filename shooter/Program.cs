using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shooter {
    internal class Program {
        static int playerX = 0;
        static int playerY = 0;
        static int consoleWidth;
        static int consoleHeight;

        static void Main(string[] args)
        {
            Initialize();
            DrawPlayer();
            DisplayCoordinates();

            ConsoleKey key;
            do {
                key = Console.ReadKey(true).Key; 

                switch (key) {
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:
                        MovePlayer(0, -1);
                        break;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        MovePlayer(0, 1);
                        break;
                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        MovePlayer(-1, 0);
                        break;
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        MovePlayer(1, 0);
                        break;
                    case ConsoleKey.Enter:
                        Console.WriteLine(" Удар");
                        DisplayCoordinates();
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine(" Выход");
                        break;
                    default:
                        Console.WriteLine("Error: \a");
                        DisplayCoordinates(); 
                        break;
                }

            } while (key != ConsoleKey.Escape);

            Console.CursorVisible = true;
        }

        static void Initialize()
        {
            consoleWidth = Console.WindowWidth;
            consoleHeight = Console.WindowHeight;

            playerX = consoleWidth / 2;
            playerY = consoleHeight / 2;

            Console.CursorVisible = false;
            Console.Clear();
        }

        static void MovePlayer(int deltaX, int deltaY)
        {
            int oldX = playerX;
            int oldY = playerY;
              
            int newX = playerX + deltaX;
            int newY = playerY + deltaY;

            if (newX >= 0 && newX < consoleWidth && newY >= 0 && newY < consoleHeight - 1) {
                playerX = newX;
                playerY = newY;

                Console.SetCursorPosition(oldX, oldY);
                Console.Write(' ');

                DrawPlayer();
                DisplayCoordinates();
            }
        }

        static void DrawPlayer()
        {
            Console.SetCursorPosition(playerX, playerY);
            Console.Write('@');
        }

        static void DisplayCoordinates()
        {
            int currentLeft = Console.CursorLeft;
            int currentTop = Console.CursorTop;

            Console.SetCursorPosition(0, consoleHeight - 1);
            Console.Write(new string(' ', consoleWidth - 1));

            Console.SetCursorPosition(0, consoleHeight - 1);
            Console.Write($"Координаты: X={playerX}, Y={playerY}");

            Console.SetCursorPosition(currentLeft, currentTop);
        }
    }
}