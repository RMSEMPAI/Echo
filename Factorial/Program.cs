using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для котрого надо посчитать факториал:");
            var x = int.Parse(Console.ReadLine());
            var ans = Factorial(x);
            Console.WriteLine("Факториал равен: {0}",ans);
            Console.ReadKey();
        }
        static decimal Factorial(int x)
        {
            if (x == 0) { return 1; }
            else { return x * Factorial(x - 1); }
        }
    }
}
