using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string rowToFormat = "{0}{1}{0}";
            int firstRowAsterisk = 1;
            int firstRowDash = (n - 1) / 2;
            if (n % 2 == 0)
                firstRowAsterisk = 2;
            int roofRows = (n + 1) / 2;
            for (int i = 0; i < roofRows; i++)
            {
                string roof = string.Format(rowToFormat, new string('-', firstRowDash), new string('*', firstRowAsterisk));
                Console.WriteLine(roof);
                firstRowDash--;
                firstRowAsterisk += 2;
            }

            int bodyRows = n / 2;
            for (int i = 0; i < bodyRows; i++)
            {
                string body = string.Format(rowToFormat, '|', new string('*', n - 2));
                Console.WriteLine(body);
            }
        }
    }
}
