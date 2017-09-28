using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZPIT_2.Peperuda
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string FormatOfRow = "{0}{1} {2}{0}";
            string FormatOfMiddleRow = "{0}@{0}";

            int flag = 0;

            string topRowsWithAsterisks = string.Format(FormatOfRow, new string('*', n - 2), '\\', '/');
            string topRowsWithDash = string.Format(FormatOfRow, new string('-', n - 2), '\\', '/');
            string middleRow = string.Format(FormatOfMiddleRow, new string(' ', n - 1));
            string botRowsWithAsterisks = string.Format(FormatOfRow, new string('*', n - 2), '/', '\\');
            string botRowsWithDash = string.Format(FormatOfRow, new string('-', n - 2), '/', '\\');

            int rows = 2 * (n - 2) + 1;

            for (int i = 1; i <= rows; i++)
            {
                if (i == (rows + 1) / 2)
                {
                    Console.WriteLine(middleRow);
                    flag = 1;
                }
                else
                {
                    if (flag == 0)
                    {
                        if (i % 2 == 1)
                            Console.WriteLine(topRowsWithAsterisks);
                        else
                            Console.WriteLine(topRowsWithDash);
                    }
                    else
                        if (i % 2 == 1)
                        Console.WriteLine(botRowsWithAsterisks);
                    else
                        Console.WriteLine(botRowsWithDash);
                }
            }
        }
    }
}
