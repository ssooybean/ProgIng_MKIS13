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
            string s2 = s.Replace(".", "");
            Console.WriteLine($"Измененная строка: {s2}");
            for(int i = 0; i<s.Length; i++)
            {
                if (s[i] != s2[i])
                {
                    count++;
                }
            }
            Console.WriteLine($"\nКоличество  удалений {count}.\n");
        }
    }
}
