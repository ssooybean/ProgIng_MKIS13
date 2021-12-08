using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива:\t");
            int n = int.Parse(Console.ReadLine());
            int[] MyArray = new int[n];
            int count = 0;
            Console.WriteLine($"Введите {n} целых чисел (после каждого нажмите Shift).");
            for (int i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i < MyArray.Length - 1; i++)
            {
                if(MyArray[i] > MyArray[i-1] && MyArray[i] > MyArray[i + 1])
                {
                    count++;
                }
            }
            Console.WriteLine($"{count} чисел в массиве больше двух своих соседей.");
        }
    }
}
