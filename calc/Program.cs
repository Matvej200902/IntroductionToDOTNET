using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc {
    internal class Program {
        static void Main(string[] args)
        {
            Console.Write("Введите число a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double sum = a + b;

            Console.WriteLine($"Результат: {sum}");
        }
    }
}
