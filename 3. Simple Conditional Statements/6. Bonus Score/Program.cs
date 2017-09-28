using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            double pts = 0;

            if (num < 100)
                pts += 5;
            else if (num <= 1000)
                pts = num * 0.20;
            else
                pts = num * 0.10;
            if (num % 2 == 0)
                pts++;
            else if (num % 10 == 5)
                pts += 2;

            Console.WriteLine(pts);
            Console.WriteLine(pts+num);
        }
    }
}
