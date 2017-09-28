using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Powers_of_two
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());

            for (int i = 0; i < power + 1; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}
