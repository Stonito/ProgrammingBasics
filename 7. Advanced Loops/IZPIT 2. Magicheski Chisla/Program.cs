using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZPIT_2.Magicheski_Chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            int magicNumber = int.Parse(Console.ReadLine());
            int result = 1;
            for (int i = 100000; i <= 999999; i++)
            {
                result = 1;
                int n = i;
                do
                {
                    result = result * (n % 10);
                    n = n / 10;
                } while (n > 0);
                if (result == magicNumber)
                {
                    Console.Write("{0} ", i);
                }

            }
        }
    }
}
