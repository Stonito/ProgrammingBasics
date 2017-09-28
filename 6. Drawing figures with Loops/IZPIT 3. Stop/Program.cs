using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZPIT_3.Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  // (n+1)*4 columns, (n+1)*2 rows

            Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string('_', n * 2 + 1));

            string topRowsFormat = "{0}//{1}\\\\{0}";
            string middleRowFormat = "//{0}STOP!{0}\\\\";
            string botRowsFormat = "{0}\\\\{1}//{0}";
            int countOfSideDots = n;
            int countOfMiddleDownDashes = n * 2 - 1;

            for (int i = 1; i <= n; i++)
            {
                string currentRow = string.Format(topRowsFormat, new string('.', countOfSideDots), new string('_', countOfMiddleDownDashes));
                Console.WriteLine(currentRow);
                countOfSideDots--;
                countOfMiddleDownDashes += 2;
            }

            string middleRow = string.Format(middleRowFormat, new string('_', n * 2 - 3));
            Console.WriteLine(middleRow);

            for (int i = 1; i <= n; i++)
            {
                string currentRow = string.Format(botRowsFormat, new string('.', countOfSideDots), new string('_', countOfMiddleDownDashes));
                Console.WriteLine(currentRow);
                countOfSideDots++;
                countOfMiddleDownDashes -= 2;
            }
        }
    }
}
