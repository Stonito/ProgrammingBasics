using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char dash = '-';
            char asterisk = '*';
            string rowToFormat = "{0}{1}{2}{1}{0}";
            int firstAndLastRowAsterisk = 1;
            if (n % 2 == 0)
                firstAndLastRowAsterisk = 2;
            int firstAndLastRowSideDash = (n - 1) / 2;

            Console.WriteLine("{0}{1}{0}", new string(dash, firstAndLastRowSideDash), new string(asterisk, firstAndLastRowAsterisk));

            int topRows = (n - 1) / 2;
            int topSideDashes = (n - 3) / 2;
            int topMiddleDashes = firstAndLastRowAsterisk;
            for (int i = 0; i < topRows; i++)
            {
                string top = string.Format(rowToFormat, new string(dash, topSideDashes), asterisk, new string(dash, topMiddleDashes));
                Console.WriteLine(top);
                topSideDashes--;
                topMiddleDashes += 2;
            }

            int botSideDashes = topSideDashes + 2;
            int botMiddleDashes = topMiddleDashes - 4;
            for (int i = 0; i < topRows-1; i++)
            {
                string bot = string.Format(rowToFormat, new string(dash, botSideDashes), asterisk, new string(dash, botMiddleDashes));
                Console.WriteLine(bot);
                botSideDashes++;
                botMiddleDashes--;
                botMiddleDashes--;
            }

            if (n > 2)
                Console.WriteLine("{0}{1}{0}", new string(dash, firstAndLastRowSideDash), new string(asterisk, firstAndLastRowAsterisk));

        }
    }
}

