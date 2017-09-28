using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Square_of_stars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N="); //Dava greshka tupiq judge lol
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{new string('*', n)}");
            for (int i = 1; i <= n - 2; i++)
            {
                Console.WriteLine($"*{new string(' ', n - 2)}*");
            }
            Console.WriteLine($"{new string('*', n)}");
        }
    }
}
