using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstPair = 0;
            int secondPair = 0;
            int pairDiff = 0;

            for (int i = 0; i < n; i++)
            {
                secondPair = firstPair;

                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());

                firstPair = firstNum + secondNum;

                if(i>0)
                {
                    if (Math.Abs(secondPair - firstPair) > pairDiff)
                        pairDiff = Math.Abs(secondPair - firstPair);
                      
                }
            }

            if(pairDiff==0)
                Console.WriteLine($"Yes, value {firstPair}");
            else
                Console.WriteLine($"No, maxdiff {pairDiff}");
        }
    }
}
