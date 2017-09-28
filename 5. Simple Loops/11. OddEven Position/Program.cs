using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.OddEven_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double evenSum = 0;
            double evenMax = double.MinValue;
            double evenMin = double.MaxValue;
            double oddMax = double.MinValue;
            double oddMin = double.MaxValue;

            for (int i = 0; i < n; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());
                if(i%2==0)
                {
                    if (currentNumber > oddMax)
                        oddMax = currentNumber;
                    if (currentNumber < oddMin)
                        oddMin = currentNumber;
                    oddSum += currentNumber;
                }
                else
                {     
                    if (currentNumber > evenMax)
                        evenMax = currentNumber;
                    if (currentNumber < evenMin)
                        evenMin = currentNumber;
                    evenSum += currentNumber;
                }
            }

            Console.WriteLine($"OddSum {oddSum}");
            if (n == 0)
            {
                Console.WriteLine($"OddMin No");
                Console.WriteLine($"OddMax No");
            }
            else
            {
                Console.WriteLine($"OddMin {oddMin}");
                Console.WriteLine($"OddMax {oddMax}");
            }
            Console.WriteLine($"EvenSum {evenSum}");
            if (n == 0 || n == 1)
            {
                Console.WriteLine($"EvenMin No");
                Console.WriteLine($"EvenMax No");
            }
            else
            {
                Console.WriteLine($"EvenMin {evenMin}");
                Console.WriteLine($"EvenMax {evenMax}");
            }
        }
    }
}
