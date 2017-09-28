using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZPIT_4.Rekolta
{
    class Program
    {
        static void Main(string[] args)
        {
            int ploshtLoze = int.Parse(Console.ReadLine());
            double grozdeZa1KvM = double.Parse(Console.ReadLine());
            int nujniLitriVino = int.Parse(Console.ReadLine());
            int broiRabotnici = int.Parse(Console.ReadLine());

            double izkaraniLitriVino = 0.4*((ploshtLoze * grozdeZa1KvM) / 2.5);

            double razlika = izkaraniLitriVino - nujniLitriVino;

            if(razlika>=0)
            {
                razlika = Math.Ceiling(razlika);
                double litersPerPerson = Math.Ceiling(razlika / broiRabotnici);
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(izkaraniLitriVino)} liters.");
                Console.WriteLine($"{razlika} liters left -> {litersPerPerson} liters per person.");
            }
            else
            {
                razlika = Math.Abs(razlika);
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(razlika)} liters wine needed.");
            }
        }
    }
}
