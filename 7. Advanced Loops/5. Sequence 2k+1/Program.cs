using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());
            int n = 1;

            while (n<=maxNumber)
            {
                Console.WriteLine(n);
                n = 2 * n + 1;
            }
        }
    }
}
