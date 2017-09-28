using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int emptySpaces = n - 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', emptySpaces));
                Console.Write("*");
                if (i > 0)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(" *");
                    }
                }     
                Console.WriteLine();
                emptySpaces--;
            }

            emptySpaces += 2;

            for (int i = n; i > 1 ; i--)
            {
                Console.Write(new string(' ', emptySpaces));
                Console.Write("*");
                for (int j = 2; j < i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                emptySpaces++;
            }

        }
    }
}
