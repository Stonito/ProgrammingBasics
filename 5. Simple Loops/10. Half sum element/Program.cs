using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Half_sum_element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > max)
                    max = currentNumber;
                sum += currentNumber;
            }

            if(sum-max==max)
                Console.WriteLine($"Yes, sum = {max}");
            else
                Console.WriteLine($"No, diff = {Math.Abs(sum-2*max)}");
        }
    }
}
