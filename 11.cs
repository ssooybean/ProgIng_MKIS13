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
            var n = Convert.ToInt32(Console.ReadLine());
            var array = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
