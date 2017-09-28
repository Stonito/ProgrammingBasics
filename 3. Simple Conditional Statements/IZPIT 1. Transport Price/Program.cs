using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZPIT_1.Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var km = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            double cena = 0;

            if (km < 20)
            {
                if (dayOrNight == "day")
                    cena = km * 0.79 + 0.70;
                else if (dayOrNight == "night")
                    cena = km * 0.90 + 0.70;
            }
            else if (km < 100)
                cena = km * 0.09;
            else
                cena = km * 0.06;
            Console.WriteLine("{0:f2}", cena);

       }
    }
}
