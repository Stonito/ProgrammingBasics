using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.OddEven_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOdd = 0;
            int sumEven = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (i % 2==0)
                    sumOdd += currentNumber;
                else
                    sumEven += currentNumber;
            }

            if (sumEven == sumOdd)
                Console.WriteLine($"Yes, sum = {sumEven}");
            else
                Console.WriteLine($"No, diff = {Math.Abs(sumEven - sumOdd)}");
        }
    }
}
