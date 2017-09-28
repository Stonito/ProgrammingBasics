using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZPIT_5.Dnevna_Pechalba
{
    class Program
    {
        static void Main(string[] args)
        {
            var rabDni = int.Parse(Console.ReadLine());
            var pariDen = double.Parse(Console.ReadLine());
            var kursDolar = double.Parse(Console.ReadLine());

            var zaplata = rabDni * pariDen;
            var godDohod = 12 * zaplata + 2.5 * zaplata;
            godDohod = godDohod - 0.25 * godDohod;
            var chistaPech = (godDohod * kursDolar) / 365;

            Console.WriteLine("{0:f2}", chistaPech);
        }
    }
}
