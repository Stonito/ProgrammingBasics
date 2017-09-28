using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value for a: ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("Enter value for b: ");
            var b = double.Parse(Console.ReadLine());
            Console.Write("S=a.b=");
            Console.WriteLine(a * b);
        }
    }
}
