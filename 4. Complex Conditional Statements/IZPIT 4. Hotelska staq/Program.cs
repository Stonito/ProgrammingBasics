using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZPIT_4.Hotelska_staq
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double broiNaNoshtuvki = int.Parse(Console.ReadLine());

            double cenaStudio = 0;
            double cenaApartament = 0;

            if (month == "May" || month == "October")
            {
                cenaStudio = 50 * broiNaNoshtuvki;
                cenaApartament = 65 * broiNaNoshtuvki;
                if (broiNaNoshtuvki > 7 && broiNaNoshtuvki <= 14)
                    cenaStudio = cenaStudio - 0.05 * cenaStudio;
                else if (broiNaNoshtuvki > 14)
                {
                    cenaStudio = cenaStudio - 0.3 * cenaStudio;
                    cenaApartament = cenaApartament - 0.1 * cenaApartament;
                }

            }
            else if(month=="June"||month=="September")
            {
                cenaStudio = 75.2 * broiNaNoshtuvki;
                cenaApartament = 68.7 * broiNaNoshtuvki;
                if (broiNaNoshtuvki > 14)
                {
                    cenaStudio = cenaStudio - 0.2 * cenaStudio;
                    cenaApartament = cenaApartament - 0.1 * cenaApartament;
                }
            }
            else if (month == "July" || month == "August")
            {
                cenaStudio = 76 * broiNaNoshtuvki;
                cenaApartament = 77 * broiNaNoshtuvki;
                if (broiNaNoshtuvki > 14)
                    cenaApartament = cenaApartament - 0.1 * cenaApartament;
            }
            Console.WriteLine("Apartment: {0:f2} lv.", cenaApartament);
            Console.WriteLine("Studio: {0:f2} lv.", cenaStudio);



        }
    }
}
