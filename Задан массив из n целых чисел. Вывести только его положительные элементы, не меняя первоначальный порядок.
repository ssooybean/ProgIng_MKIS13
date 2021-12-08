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
            Console.WriteLine($"Введите {n} целых чисел (после каждого нажмите Shift).");
            for (int i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Положительные элементы массива:\t");
            for (int i = 0; i < MyArray.Length; i++)
            {
                if(MyArray[i] >= 0)
                {
                    Console.Write($"{MyArray[i]} ");
                }
            }
            Console.WriteLine("\n");
        }
    }
}
