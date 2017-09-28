using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZPIT_1.Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int currentFirstNumber = 1; currentFirstNumber <= n-1 ; currentFirstNumber++)
            {
                for (int currentSecondNumber = 1; currentSecondNumber <= n-1; currentSecondNumber++)
                {
                    for (char currentFirstChar = 'a'; currentFirstChar < 'a' + l; currentFirstChar++)
                    {
                        for (char currentSecondChar = 'a'; currentSecondChar < 'a' + l; currentSecondChar++)
                        {
                            for (int currentLastNumber = 2; currentLastNumber <= n; currentLastNumber++)
                            {
                                if (currentLastNumber > currentFirstNumber && currentLastNumber > currentSecondNumber)
                                    Console.Write("{0}{1}{2}{3}{4} ", currentFirstNumber, currentSecondNumber, currentFirstChar, currentSecondChar, currentLastNumber);
                            }
                        }

                    }

                }

            }
        }
    }
}
