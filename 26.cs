using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    class Program
    {
        static void MinmaxSeq(ref int maximum, ref int minimum)
        {
            Console.WriteLine("Вводите последовательность целых чисел через shift, если захотите завершить введите 0.");
            int x;
            do
            {
                x = int.Parse(Console.ReadLine());
                if (x < minimum && x!= 0)
                {
                    minimum = x; ;
                }
                if (x > maximum && x != 0)
                {
                    maximum = x;
                }
            }
            while (x != 0);
        }
        static void Main(string[] args)
        {
            int min = 1000000;
            int max = -1000000;
            MinmaxSeq(ref max, ref min);
            Console.WriteLine($"Минимальное число последовательности = {min}, максимальное число последовательности = {max}");
        }
    }
}
