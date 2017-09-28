using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZPIT_2.Delenie_bez_ostatuk
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

            for (int i = 0; i < numberOfDigits; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber % 2 == 0)
                    p1 += percentPerNumber;
                if (currentNumber % 3 == 0)
                    p2 += percentPerNumber;
                if (currentNumber % 4 == 0)
                    p3 += percentPerNumber;
            }

            Console.WriteLine("{0:f2}%", p1);
            Console.WriteLine("{0:f2}%", p2);
            Console.WriteLine("{0:f2}%", p3);
        }
    }
}
