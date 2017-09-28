using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            if (a == "m")
            {
                if (b == "cm") { Console.WriteLine(n * 100); }
                if (b == "mm") { Console.WriteLine(n * 1000); }
                if (b == "mi") { Console.WriteLine(n * 0.000621371); }
                if (b == "in") { Console.WriteLine(n * 39.3701); }
                if (b == "km") { Console.WriteLine(n * 0.001); }
                if (b == "ft") { Console.WriteLine(n * 3.28084); }
                if (b == "yd") { Console.WriteLine(n * 1.09361); }
                if (b == "m") { Console.WriteLine(n); }
            }
            if (a == "cm")
            {
                if (b == "m") { Console.WriteLine(n * 0.01); }
                if (b == "mm") { Console.WriteLine(n * 10); }
                if (b == "mi") { Console.WriteLine((n * 0.01) * 0.000621371); }
                if (b == "in") { Console.WriteLine(n * 0.3937007874); }
                if (b == "km") { Console.WriteLine((n * 0.01) * 0.001); }
                if (b == "ft") { Console.WriteLine(n * 0.0328084); }
                if (b == "yd") { Console.WriteLine(n * 0.0109361); }
                if (b == "cm") { Console.WriteLine(n); }
            }
            if (a == "mi")
            {
                if (b == "m") { Console.WriteLine(n * 1609.344); }
                if (b == "mm") { Console.WriteLine(n * 1609344); }
                if (b == "cm") { Console.WriteLine(n * 160934.40); }
                if (b == "in") { Console.WriteLine(n * 63360); }
                if (b == "km") { Console.WriteLine(n * 1.60934); }
                if (b == "ft") { Console.WriteLine(n * 5280); }
                if (b == "yd") { Console.WriteLine(n * 1760); }
                if (b == "mi") { Console.WriteLine(n); }
            }
            if (a == "in")
            {
                if (b == "m") { Console.WriteLine(n * 0.0254); }
                if (b == "mm") { Console.WriteLine(n * 25.4); }
                if (b == "cm") { Console.WriteLine(n * 2.54); }
                if (b == "mi") { Console.WriteLine(n / 63360.00); }
                if (b == "km") { Console.WriteLine(n / 39370.08); }
                if (b == "ft") { Console.WriteLine(n * 0.0833333); }
                if (b == "yd") { Console.WriteLine(n * 0.0277778); }
                if (b == "in") { Console.WriteLine(n); }
            }
            if (a == "km")
            {
                if (b == "m") { Console.WriteLine(n * 1000); }
                if (b == "mm") { Console.WriteLine(n * 1000000); }
                if (b == "cm") { Console.WriteLine(n * 100000); }
                if (b == "mi") { Console.WriteLine(n * 0.62137119); }
                if (b == "in") { Console.WriteLine(n * 39370.08); }
                if (b == "ft") { Console.WriteLine(n * 3280.83989501); }
                if (b == "yd") { Console.WriteLine(n * 1093.6133); }
                if (b == "km") { Console.WriteLine(n); }
            }
            if (a == "yd")
            {
                if (b == "m") { Console.WriteLine(n * 0.9144); }
                if (b == "mm") { Console.WriteLine(n * 914.4); }
                if (b == "cm") { Console.WriteLine(n * 91.44); }
                if (b == "mi") { Console.WriteLine(n * 0.000568182); }
                if (b == "in") { Console.WriteLine(n * 36); }
                if (b == "ft") { Console.WriteLine(n * 3); }
                if (b == "km") { Console.WriteLine(n * 0.0009144); }
                if (b == "yd") { Console.WriteLine(n); }
            }
            if (a == "ft")
            {
                if (b == "m") { Console.WriteLine(n * 0.3048); }
                if (b == "mm") { Console.WriteLine(n * 304.8); }
                if (b == "cm") { Console.WriteLine(n * 30.48); }
                if (b == "mi") { Console.WriteLine(n * 0.000189394); }
                if (b == "in") { Console.WriteLine(n * 12); }
                if (b == "yd") { Console.WriteLine(n * 0.333333); }
                if (b == "km") { Console.WriteLine(n * 0.0003048); }
                if (b == "ft") { Console.WriteLine(n); }
            }
            if (a == "mm")
            {
                if (b == "m") { Console.WriteLine(n * 0.001); }
                if (b == "ft") { Console.WriteLine(n * 0.00328084); }
                if (b == "cm") { Console.WriteLine(n * 0.1); }
                if (b == "mi") { Console.WriteLine(n / 1609344.01); }
                if (b == "in") { Console.WriteLine(n * 0.0393701); }
                if (b == "yd") { Console.WriteLine(n * 0.00109361); }
                if (b == "km") { Console.WriteLine(n / 1000000); }
                if (b == "mm") { Console.WriteLine(n); }
            }
        }
    }
}
