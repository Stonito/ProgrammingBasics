using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial = int.Parse(Console.ReadLine());
            int result = 1;

            do
            {
                result *= factorial--;
            } while (factorial>0);

            Console.WriteLine(result);
        }
    }
}
