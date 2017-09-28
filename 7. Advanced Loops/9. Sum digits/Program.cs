using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Sum_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            do
            {
                int lastDigit = number % 10;
                int newNumber = number / 10;
                number = newNumber;
                sum += lastDigit;
            } while (number > 0);

            Console.WriteLine(sum);
        }
    }
}
