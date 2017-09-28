using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZPIT_1.Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());

            h = h * 100;
            w = w * 100-100;

            h = h / 120;
            w = w / 70;

            h = Math.Floor(h);
            w = Math.Floor(w);

            var sts = h * w - 3;
            Console.WriteLine(sts);


        }
    }
}
