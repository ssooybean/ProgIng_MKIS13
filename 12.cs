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
            Console.Write("Введите количество чисел в последовательности: ");
            var n = int.Parse(Console.ReadLine());
            var p = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            var count = 0;

            for (var i = 1; i < n - 1; i++)
            {
                if (p[i - 1] % 2 == 0 && p[i + 1] % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
