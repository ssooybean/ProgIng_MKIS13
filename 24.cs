using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    class Program
    {
        static int Perimeter(int x1, int x2, int x3)
        {
            return x1 + x2 + x3;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите длины трех сторон: ");
            string[] lst = Console.ReadLine().Split();
            int a = int.Parse(lst[0]);
            int b = int.Parse(lst[1]);
            int c = int.Parse(lst[2]);
            Console.WriteLine($"Периметр заданной фигуры {Perimeter(a, b, c)}");

        }
    }
}
