using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZPIT_3.Specialni_chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i < 10000; i++)
            {
                int forthNumber = i % 10;
                int newI = (i - forthNumber) / 10;
                if (forthNumber == 0)
                    continue;
                if(n % forthNumber == 0)
                {
                    int thirdNumber = newI % 10;
                    newI = (newI - thirdNumber) / 10;
                    if (thirdNumber == 0)
                        continue;
                    if (n % thirdNumber == 0)
                    {
                        int secondNumber = newI % 10;
                        newI = (newI - secondNumber) / 10;
                        if (secondNumber == 0)
                            continue;
                        if (n % secondNumber == 0)
                        {
                            if (newI == 0)
                                continue;
                            if (n % newI == 0)
                                Console.Write($"{newI}{secondNumber}{thirdNumber}{forthNumber} ");
                        }
                    }
                   
                }
            }
        }
    }
}
