using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZPIT_2.Operacii_mejdu_chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            char o = char.Parse(Console.ReadLine());

            switch (o)
            {
                case '+':
                    if ((n1 + n2) % 2 == 0)
                        Console.WriteLine($"{n1} {o} {n2} = {n1 + n2} - even");
                    else
                        Console.WriteLine($"{n1} {o} {n2} = {n1 + n2} - odd");
                    break;
                case '-':
                    if ((n1 - n2) % 2 == 0)
                        Console.WriteLine($"{n1} {o} {n2} = {n1 - n2} - even");
                    else
                        Console.WriteLine($"{n1} {o} {n2} = {n1 - n2} - odd");
                    break;
                case '*':
                    if ((n1 * n2) % 2 == 0)
                        Console.WriteLine($"{n1} {o} {n2} = {n1 * n2} - even");
                    else
                        Console.WriteLine($"{n1} {o} {n2} = {n1 * n2} - odd");
                    break;
                case '/':
                    if (n2 == 0)
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    else
                    {
                        double result = n1 / n2;
                        Console.WriteLine("{0} / {1} = {2:f2}", n1, n2, result);
                    }
                    break;
                case '%':
                    if (n2 == 0)
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    else
                        Console.WriteLine($"{n1} % {n2} = {n1 % n2}");
                    break;
                default:
                    break;

            }
        }

    }
}
