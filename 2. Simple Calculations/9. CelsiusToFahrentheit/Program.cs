using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.CelsiusToFahrentheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheits = celsius * 9 / 5 + 32;
            Console.WriteLine($"Fahrenheit = {fahrenheits}");
        }
    }
}
