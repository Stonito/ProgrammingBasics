using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int currentRow = 1;
            int currentNumber = 1;

            for (int i = 0;; i++)
            {
                for (int j = 0; j < currentRow; j++)
                {
                    if (currentNumber == numbers + 1)
                    {
                        Console.WriteLine();
                        return;     
                    }
                    Console.Write("{0} ", currentNumber);
                    currentNumber++;
                }
                currentRow++;
                Console.WriteLine();
            }
        }
    }
}
