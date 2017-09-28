using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = i; j <= rows ; j++)
                {
                    Console.Write("{0} ", j);
                }
                

                for (int j = rows - 1; j > rows - i  ; j--)
                {
                    Console.Write("{0} ", j);
                }

                Console.WriteLine();
            }
        }
    }
}
