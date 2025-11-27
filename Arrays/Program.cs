using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays {
    internal class Program {
        static void Main(string[] args)
        {
            const string delimiter = "\n-----------------------------------------------------------------------\n";
            int[] arr = { 3, 5, 8, 13, 21 };
            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine(arr[i] + "\t");
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
        }
    }
}
