using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes {
    internal class Program {
        static readonly string delimiter = "\n-----------------------------------------------------------------\n";
        static void Main(string[] args)
        {
            Console.WriteLine("Data");
            Console.WriteLine("byte");
            Console.WriteLine($"byte занимает {sizeof(byte)} байт памяти, и принимает значения в диапазоне");
            Console.WriteLine($"Unsimpol от {byte.MinValue} до {byte.MaxValue}, {typeof(byte)}");
            Console.WriteLine($"Simbol от {sbyte.MinValue} до {sbyte.MaxValue}, {typeof(sbyte)}");
            Console.WriteLine(delimiter);

            Console.WriteLine("short");
            Console.WriteLine($"short занимает {sizeof(short)} байт памяти, и принимает значения в диапазоне");
            Console.WriteLine($"Unsimpol от {ushort.MinValue} до {ushort.MaxValue}, {typeof(ushort)}");
            Console.WriteLine($"Simbol от {short.MinValue} до {short.MaxValue}, {typeof(short)}");
            Console.WriteLine(delimiter);

            Console.WriteLine("int");
            Console.WriteLine($"short занимает {sizeof(int)} байт памяти, и принимает значения в диапазоне");
            Console.WriteLine($"Unsimpol от {uint.MinValue} до {uint.MaxValue}, {typeof(uint)}");
            Console.WriteLine($"Simbol от {int.MinValue} до {int.MaxValue}, {typeof(int)}");
            Console.WriteLine(delimiter);

            Console.WriteLine("long");
            Console.WriteLine($"short занимает {sizeof(long)} байт памяти, и принимает значения в диапазоне");
            Console.WriteLine($"Unsimpol от {ulong.MinValue} до {ulong.MaxValue}, {typeof(ulong)}");
            Console.WriteLine($"Simbol от {long.MinValue} до {long.MaxValue}, {typeof(long)}");
            Console.WriteLine(delimiter);

            Console.WriteLine("float");
            Console.WriteLine($"short занимает {sizeof(float)} байт памяти, и принимает значения в диапазоне");
            Console.WriteLine($"Simbol от {float.MinValue} до {float.MaxValue}, {typeof(float)}");
            Console.WriteLine(delimiter);


        }
    }
}
