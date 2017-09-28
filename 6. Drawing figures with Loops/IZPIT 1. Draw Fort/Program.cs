using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZPIT_1.Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string formatFirstAndLastRow = "{0}{1}{2}{3}{0}{1}{2}";

            int countOfMiddleDownDashes = 0;
            if (n > 4)
                countOfMiddleDownDashes = (n*2 - (n/2)*2 - 4);

            string firstRow = string.Format(formatFirstAndLastRow, '/', new string('^', n / 2), '\\', new string('_', countOfMiddleDownDashes));
            string lastRow = string.Format(formatFirstAndLastRow, '\\', new string('_', n / 2), '/', new string(' ', countOfMiddleDownDashes));



            Console.WriteLine(firstRow);

            int middleRows = n - 2;

            for (int i = 0; i < middleRows; i++)
            {
                if ((i + 1 == middleRows) && n > 4)
                    Console.WriteLine("|{0}{1}{0}|", new string(' ', n/2 + 1), new string('_', countOfMiddleDownDashes));
                else
                    Console.WriteLine("|{0}|", new string(' ', 2 * n - 2));
            }

            Console.WriteLine(lastRow);

        }
    }
}
