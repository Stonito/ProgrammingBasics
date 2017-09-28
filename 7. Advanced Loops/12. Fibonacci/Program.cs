using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibonacci = int.Parse(Console.ReadLine());

            int firstNumber = 1;
            int secondNumber = 1;

            for (int i = 0; i < fibonacci; i++)
            {
                int newSecondNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = newSecondNumber;
            }

            Console.WriteLine(firstNumber);

        }
    }
}
