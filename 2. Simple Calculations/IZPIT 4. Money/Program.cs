using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZPIT_4.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitCoin = int.Parse(Console.ReadLine());
            var china = double.Parse(Console.ReadLine());
            var komis = double.Parse(Console.ReadLine());

            double leva = bitCoin * 1168;
            var dolara = china * 0.15;
            leva = leva + dolara * 1.76;
            var evro = leva / 1.95;

            var suma = evro - (komis / 100) * evro;

            Console.WriteLine("{0:f2}", suma);

        }
    }
}
