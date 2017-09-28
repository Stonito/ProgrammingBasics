using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZPIT_2.Zelenchukova_borsa
{
    class Program
    {
        static void Main(string[] args)
        {
            var cenaZel = double.Parse(Console.ReadLine());
            var cenaPlod = double.Parse(Console.ReadLine());
            var kgZel = int.Parse(Console.ReadLine());
            var kgPlod = int.Parse(Console.ReadLine());

            var prZel = cenaZel * kgZel;
            var prPlod = cenaPlod * kgPlod;

            var pr = Math.Round((prZel + prPlod)/1.94, 2);
            Console.WriteLine(pr);
        }
    }
}
