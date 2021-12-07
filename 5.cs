using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Через пробел задайте первый член арифмитической прогрессии, шаг и количество искомых членов: ");
            string[] st = Console.ReadLine().Split();
            double first = double.Parse(st[0]);
            double d = double.Parse(st[1]);
            int kolvo = int.Parse(st[2]);
            double sumpr = 0;
            for(int i = 0; i < kolvo; i++)
            {
                sumpr += first + d * i;
            }
            Console.WriteLine($"Сумма первых членов заданной арифмитической прогрессии равна {sumpr}.");
        }
    }
}
