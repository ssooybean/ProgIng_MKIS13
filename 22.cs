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
            Console.Write("Введите русскоязычную строку:\t");
            string s = Console.ReadLine();
            int count = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i]== ' ' || s[i] == '.')
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество слов в тексте равно {count}.");
        }
    }
}
