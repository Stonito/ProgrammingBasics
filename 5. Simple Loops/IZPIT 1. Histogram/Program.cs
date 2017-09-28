using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZPIT_1.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDigits = int.Parse(Console.ReadLine());

            double percentPerNumber = 100.0 / numberOfDigits;

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < numberOfDigits; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber < 200)
                    p1 += percentPerNumber;
                else if (currentNumber < 400)
                    p2 += percentPerNumber;
                else if (currentNumber < 600)
                    p3 += percentPerNumber;
                else if (currentNumber < 800)
                    p4 += percentPerNumber;
                else if (currentNumber >= 800)
                    p5 += percentPerNumber;

            }

            Console.WriteLine("{0:f2}%", p1);
            Console.WriteLine("{0:f2}%", p2);
            Console.WriteLine("{0:f2}%", p3);
            Console.WriteLine("{0:f2}%", p4);
            Console.WriteLine("{0:f2}%", p5);
        }
    }
}
