using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите стоимость покупки: ");
            double cost = double.Parse(Console.ReadLine());
            if (cost <= 500)
            {
                Console.WriteLine($"Стоимость покупки {cost}.");
                return;
            }
            if (cost > 500 && cost <= 1000)
            {
                Console.WriteLine($"Стоимость покупки {cost - cost * 0.03}.");
            }
            else
            {
                Console.WriteLine($"Стоимость покупки {cost - cost * 0.05}.");
            }
        }
    }
}
