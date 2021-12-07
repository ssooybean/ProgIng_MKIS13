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
            Console.Write("p = ");
            int p = Convert.ToInt32(Console.ReadLine());
            int i = p;
            int factorial = 1;
            do
            {
                factorial = factorial * i;
                --i;
            }
            while (i > 1);

            Console.WriteLine($"{p}!= {factorial}");
            Console.ReadLine();
        }
    }
}
