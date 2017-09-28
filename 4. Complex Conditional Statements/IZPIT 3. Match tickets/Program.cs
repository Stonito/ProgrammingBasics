using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZPIT_3.Match_tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            double broi = double.Parse(Console.ReadLine());

            string vip = "VIP";
            string normal = "Normal";

            if (broi <= 4)
                budget = budget - 0.75 * budget;
            else if (broi <= 9)
                budget = budget - 0.6 * budget;
            else if (broi <= 24)
                budget = budget - 0.5 * budget;
            else if (broi <= 49)
                budget = budget - 0.4 * budget;
            else if (broi > 50)
                budget = budget - 0.25 * budget;

            double cena = 0;
            if (category == vip)
                cena = 499.99;
            else if (category == normal)
                cena = 249.99;

            if(budget>=broi*cena)
                Console.WriteLine("Yes! You have {0:f2} leva left.", budget - broi*cena);
            else
                Console.WriteLine("Not enough money! You need {0:f2} leva.", broi* cena - budget);
        }
    }
}
