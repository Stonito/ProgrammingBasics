using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZPIT_3.Pospalivata_kotka_Tom
{
    class Program
    {
        static void Main(string[] args)
        {
            int pochivniDni = int.Parse(Console.ReadLine());
            int rabotniDni = 365 - pochivniDni;

            int timeForPlay = rabotniDni * 63 + pochivniDni * 127;
            int norma = 30000 - timeForPlay;

            int hours = Math.Abs(norma / 60);
            int minutes = Math.Abs(norma % 60);

            if(norma>0)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }

        }
    }
}
