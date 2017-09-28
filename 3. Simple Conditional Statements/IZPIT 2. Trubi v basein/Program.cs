using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZPIT_2.Trubi_v_basein
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = int.Parse(Console.ReadLine());
            var p1 = int.Parse(Console.ReadLine());
            var p2 = int.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var truba1 = p1 * h;
            var truba2 = p2 * h;

            if (truba1 + truba2 <= v)
            {
                int pr = (int)(((truba1 + truba2) / v) * 100);
                var pr1 = (int)((truba1 / (truba1 + truba2)) * 100);
                var pr2 = (int)((truba2 / (truba1 + truba2)) * 100);
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", pr, pr1, pr2);
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1:f1} liters.", h, truba1 + truba2 - v);
            }

   
        }
    }
}
