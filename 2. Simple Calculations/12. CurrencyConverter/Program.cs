using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double suma = double.Parse(Console.ReadLine());
            string enterValue = Console.ReadLine();
            string exitValue = Console.ReadLine();
            double usd = 1.79549;
            double eur = 1.95583;
            double gbp = 2.53405;

            switch(enterValue)
            {
                case "USD":
                    suma = suma * usd;
                    break;
                case "EUR":
                    suma = suma * eur;
                    break;
                case "GBP":
                    suma = suma * gbp;
                    break;
                default:
                    break;
            }
            switch (exitValue)
            {
                case "USD":
                    suma = suma / usd;
                    break;
                case "EUR":
                    suma = suma / eur;
                    break;
                case "GBP":
                    suma = suma / gbp;
                    break;
                default:
                    break;
            }
            suma = Math.Round(suma, 2);
            Console.WriteLine($"{suma} {exitValue}");
        }
    }
}
