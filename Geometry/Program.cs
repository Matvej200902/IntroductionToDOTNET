using System;

namespace Figures {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для рисования фигур");
            Console.Write("Введите размер фигуры(x и y): ");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine("\n1. Квадрат:");
            DrawRectangle(size);

            Console.WriteLine("\n2. Прямоугольный треугольник (гипотинуза справа в лево вверх):");
            DrawTriangleIncreasing(size);

            Console.WriteLine("\n3. Прямоугольный треугольник (гипотенуза справа в лево вниз):");
            DrawTriangleDecreasing(size);

            Console.WriteLine("\n4. Треугольник (гипотенуза слева вправо вниз):");
            DrawTriangleRightShift(size);

            Console.WriteLine("\n5. Треугольник (гипотенуза слева вправо вверх):");
            DrawTriangleLeftShift(size);

            Console.WriteLine("\n6. Ромб:");
            DrawDiamond(size);

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        static void DrawRectangle(int size)
        {
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++) {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        static void DrawTriangleIncreasing(int size)
        {
            for (int i = 0; i < size; i++) {
                for (int j = 0; j <= i; j++) {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        static void DrawTriangleDecreasing(int size)
        {
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size - i; j++) {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        static void DrawTriangleRightShift(int size)
        {
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < i; j++) {
                    Console.Write("  ");
                }
                for (int j = 0; j < size - i; j++) {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        static void DrawTriangleLeftShift(int size)
        {
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size - i - 1; j++) {
                    Console.Write("  ");
                }
                for (int j = 0; j <= i; j++) {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        static void DrawDiamond(int size)
        {
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size - i - 1; j++) {
                    Console.Write(" ");
                }
                Console.Write("/");
                for (int j = 0; j < i * 2; j++) {
                    Console.Write(" ");
                }
                Console.Write("\\");
                Console.WriteLine();
            }

            for (int i = 0; i < size; i++) {
                for (int j = 0; j < i; j++) {
                    Console.Write(" ");
                }
                Console.Write("\\");
                for (int j = 0; j < (size - i - 1) * 2; j++) {
                    Console.Write(" ");
                }
                Console.Write("/");
                Console.WriteLine();
            }
        }
    }
}