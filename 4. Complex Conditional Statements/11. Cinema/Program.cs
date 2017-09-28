using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string pr = Console.ReadLine().ToLower();
            int brR = int.Parse(Console.ReadLine());
            int brK = int.Parse(Console.ReadLine());

            double cena = -1.0;

            if (pr == "premiere")
                cena = 12.0;
            else if (pr == "normal")
                cena = 7.5;
            else if (pr == "discount")
                cena = 5.0;

            Console.WriteLine("{0:f2}", cena*brK*brR);

        }
    }
}
