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
            Console.ReadLine();
            var p = Array.ConvertAll(Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), s => int.Parse(s)).ToList();
            var min = p.Min();
            var max = p.Max();
            var res = p.Select(x => x == max ? min : x == min ? max : x);
            Console.WriteLine(string.Join(" ", res));
        }
    }
}
