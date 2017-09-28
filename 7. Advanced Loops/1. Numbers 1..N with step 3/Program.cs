using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Numbers_1._.N_with_step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= maxNumber; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
