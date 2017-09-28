using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.UsdToBgn
{
    class Program
    {
        static void Main(string[] args)
        {
            double dollars = double.Parse(Console.ReadLine());
            double leva = dollars * 1.79549;
            Console.WriteLine($"Leva = {leva}");
        }
    }
}
