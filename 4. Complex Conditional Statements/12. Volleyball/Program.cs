using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double igri = (48 - h) * 3 / 4.0 + h + (2 / 3.0) * p;
            if (year == "leap")
                igri = igri + (15 / 100.0) * igri;
            igri = Math.Truncate(igri);
            Console.WriteLine(igri);
        }
    }
}
