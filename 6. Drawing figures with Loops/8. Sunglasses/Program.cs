using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string firstAndLastRow = new string('*', n * 2);
            string spaces = new string(' ', n);
            string asteriks = "*";
            int redNaRamkata = (int)(Math.Ceiling(n / 2.0) - 2);

            Console.WriteLine(firstAndLastRow + spaces + firstAndLastRow);


            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(asteriks + new string('/', (n - 1) * 2) + asteriks);

                if (i == redNaRamkata)
                    Console.Write(new string('|', n));
                else
                    Console.Write(spaces);

                Console.Write(asteriks + new string('/', (n - 1) * 2) + asteriks);
                Console.WriteLine();
            }

            Console.WriteLine(firstAndLastRow + spaces + firstAndLastRow);
        }
    }
}
