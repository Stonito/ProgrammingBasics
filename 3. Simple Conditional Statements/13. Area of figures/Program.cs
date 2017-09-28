using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Area_of_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            if (str == "square")
            {
                var a = double.Parse(Console.ReadLine());
                Console.WriteLine(a * a);
            }
            else if (str == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(a * b, 3));
            }
            else if (str == "circle")
            {
                var a = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(Math.PI * a * a, 3));
            }
            else if (str == "triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(a * b/2, 3));
            }
        }
    }
}
