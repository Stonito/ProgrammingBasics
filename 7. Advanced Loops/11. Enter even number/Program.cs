using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Enter_even_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (true)
            {
                Console.WriteLine("Enter even number: ");
                number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                    break;
                Console.WriteLine("The number is not even.");
            }

            Console.WriteLine($"Even number entered: {number}");


        }
    }
}
