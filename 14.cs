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
            Console.Write("Введите количество элементов в массиве: ");
            double n = double.Parse(Console.ReadLine());
            var array = Array.ConvertAll(Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries), s => int.Parse(s));

            int sumall = array[0];
            for (int i = 1; i < n; i++)
            {
                sumall += array[i];
            }

            double sredaref = sumall / (double)n;
            int count = 0;
            int answer = 0;

            foreach (var current in array)
            {
                if (current > sredaref)
                {
                    count++;
                    answer += current;
                }
            }

            Console.WriteLine($"{answer} {count}");
        }
    }
}
