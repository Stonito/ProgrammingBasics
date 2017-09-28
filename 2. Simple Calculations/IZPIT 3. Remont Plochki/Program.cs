using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZPIT_3.Remont_Plochki
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var l = double.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());
            var o = double.Parse(Console.ReadLine());

            var area = n * n;
            var peika = m * o;

            var area1 = area - peika;
            var plochka = w * l;

            var plochki = area1 / plochka;
            var vreme = plochki * 0.2;

            Console.WriteLine("{0:f2}", plochki);
            Console.WriteLine("{0:f2}", vreme);
        }
    }
}
