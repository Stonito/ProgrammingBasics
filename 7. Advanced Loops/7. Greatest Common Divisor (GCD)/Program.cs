using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Greatest_Common_Divisor__GCD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            while (b!=0)
            {
                int newb = a % b;
                a = b;
                b = newb;
            }
            Console.WriteLine("GCD = {0}", a);
        }
    }
}
