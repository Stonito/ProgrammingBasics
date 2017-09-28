using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Sum_seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            var sum = a + b + c;
            if (sum < 10)
                Console.WriteLine($"0:0{sum}");
            else if (sum < 60)
                Console.WriteLine($"0:{sum}");
            else if (sum < 120)
            {
                if ((sum - 60) < 10)
                    Console.WriteLine($"1:0{sum - 60}");
                else
                    Console.WriteLine($"1:{sum - 60}");
            }
            else if (sum < 180)
            {
                if ((sum - 120) < 10)
                    Console.WriteLine($"2:0{sum - 120}");
                else
                    Console.WriteLine($"2:{sum - 120}");
            }

        }
    }
}
