using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.LeftAndRight_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i < n*2; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (i < n)
                    sumLeft += currentNumber;
                else
                    sumRight += currentNumber;
            }

            if (sumLeft == sumRight)
                Console.WriteLine($"Yes, sum = {sumRight}");
            else
                Console.WriteLine($"No, diff = {Math.Abs(sumRight - sumLeft)}");
        }
    }
}
