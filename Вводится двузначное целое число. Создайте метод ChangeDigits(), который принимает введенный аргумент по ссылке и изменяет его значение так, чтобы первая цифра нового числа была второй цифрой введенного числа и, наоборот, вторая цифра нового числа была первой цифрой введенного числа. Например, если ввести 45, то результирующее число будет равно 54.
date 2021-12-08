using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    class Program
    {
        static void ChangeDigits(ref int x)
        {
            int a = x % 10;
            x = (x - a) / 10;
            x = a * 10 + x;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите двузначное число: ");
            int num = int.Parse(Console.ReadLine());
            ChangeDigits(ref num);
            Console.WriteLine(num);
        }
    }
}
