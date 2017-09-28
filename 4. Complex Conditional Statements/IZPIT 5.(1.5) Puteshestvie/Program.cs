using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZPIT_5._1._5__Puteshestvie
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string summerOrWinter = Console.ReadLine().ToLower();
            double spendings = 0.0;

            string summer = "summer";
            string winter = "winter";

            if(budget<=100)
            {
                if (summerOrWinter == summer)
                {
                    spendings = 0.3 * budget;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:f2}", spendings);

                }
                else if (summerOrWinter == winter)
                {
                    spendings = 0.7 * budget;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:f2}", spendings);
                }
            }
            else if(budget<=1000)
            {
                if (summerOrWinter == summer)
                {
                    spendings = 0.4 * budget;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - {0:f2}", spendings);

                }
                else if (summerOrWinter == winter)
                {
                    spendings = 0.8 * budget;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - {0:f2}", spendings);
                }
            }
            else
            {
                if (summerOrWinter == summer)
                {
                    spendings = 0.9 * budget;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:f2}", spendings);

                }
                else if (summerOrWinter == winter)
                {
                    spendings = 0.9 * budget;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:f2}", spendings);
                }
            }

        }
    }
}
