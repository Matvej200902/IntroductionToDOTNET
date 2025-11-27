//#define ARRAYS_1
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays {
    internal class Program {
        const string delimiter = "\n-----------------------------------------------------------------------\n";
        static void Main(string[] args)
        {
#if ARRAYS_1
            int[] arr = { 3, 5, 8, 13, 21 };
            for (int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();

            Console.Write("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            arr = new int[n];
            Random rand = new Random(0);

            int sum = 0;
            int? min = null;
            int? max = null;

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = rand.Next(100);
                sum += arr[i];

                if (min == null || arr[i] < min) min = arr[i];
                if (max == null || arr[i] > max) max = arr[i];
            }

            double average = arr.Length > 0 ? (double)sum / arr.Length : 0;

            for (int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("Сумма элементов массива: " + sum);
            Console.WriteLine("Среднее арифмитическое: " + average);
            Console.WriteLine("Минимальное: " + (min.HasValue ? min.Value.ToString() : ""));
            Console.WriteLine("Максимальное: " + (max.HasValue ? max.Value.ToString() : ""));
            Console.WriteLine(delimiter);
#endif

            Random rand = new Random(0);
            Console.Write("Введите количество строк: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество элементов строки: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[rows, cols];
            Console.WriteLine($"Количество измерений массива: {arr.Rank}");



            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++) {
                for (int j = 0; j < arr.GetLength(1); j++) {
                    arr[i, j] = rand.Next(100);
                    sum += arr[i, j];
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++) {
                for (int j = 0; j < arr.GetLength(1); j++) {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

			int min = int.MaxValue;
			int max = int.MinValue;

			for (int i = 0; i < arr.GetLength(0); i++) {
				for (int j = 0; j < arr.GetLength(1); j++) {
					int value = arr[i, j];

					sum += value;
					if (value < min) min = value;
					if (value > max) max = value;
				}
			}
			Console.WriteLine();

            Console.WriteLine($"Сумма элементов массива: {sum}");
            Console.WriteLine($"Среднее арифмитическое: {(double)sum / arr.Length}");

            Console.WriteLine(delimiter);
            Console.WriteLine($"Сумма элементов массива: {arr.Cast<int>().Sum()}");
			Console.WriteLine($"Минимальное значение: {min}");
			Console.WriteLine($"Максимальное значение: {max}");
		}
    }
}
