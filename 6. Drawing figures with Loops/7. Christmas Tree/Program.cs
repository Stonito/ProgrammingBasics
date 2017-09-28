using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {

            string middlePart = " | ";
            char emptySpace = ' ';
            char asterisk = '*';

            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}", new string(emptySpace, n), middlePart);

            int countOfEmptySpaces = n - 1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string(emptySpace, countOfEmptySpaces), new string(asterisk, i), middlePart);
                countOfEmptySpaces--;
            }
        }
    }
}
