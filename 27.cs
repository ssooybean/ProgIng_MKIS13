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
            for (int i = 120; i <= 140; i++)
            {
                int coast = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        coast++;
                    }
                }
                Console.WriteLine($"Число {i} имеет {coast} делителей;");
            }
        }
    }
}
