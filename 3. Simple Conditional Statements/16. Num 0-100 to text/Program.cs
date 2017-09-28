using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Num_0_100_to_text
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num == 0) Console.WriteLine("zero");
            else if (num >= 10 && num < 20)
            {
                switch (num)
                {
                    case 10: Console.WriteLine("ten"); break;
                    case 11: Console.WriteLine("eleven"); break;
                    case 12: Console.WriteLine("twelve"); break;
                    case 13: Console.WriteLine("thirteen"); break;
                    case 14: Console.WriteLine("fourteen"); break;
                    case 15: Console.WriteLine("fifteen"); break;
                    case 16: Console.WriteLine("sixteen"); break;
                    case 17: Console.WriteLine("seventeeen"); break;
                    case 18: Console.WriteLine("eighteen"); break;
                    case 19: Console.WriteLine("nineteen"); break;
                }
            }
            else if (num == 100) Console.WriteLine("one hundred");
            else if (num < 0 || num > 100) Console.WriteLine("invalid number");
            else
            {
                string tens = toTens(num / 10),
                       unit = toUnits(num % 10);

                if (tens != "")
                {
                    Console.Write(tens);
                    if (unit != "") Console.Write(" " + unit);
                }
                else Console.WriteLine(unit);

            }

        }

        static string toTens(int num)
        {
            switch (num)
            {
                case 0: return "";
                case 2: return "twenty";
                case 3: return "thirty";
                case 4: return "forty";
                case 5: return "fifty";
                case 6: return "sixty";
                case 7: return "seventy";
                case 8: return "eighty";
                case 9: return "ninety";
            }

            return "ERROR";

        }

        static string toUnits(int num)
        {
            switch (num)
            {
                case 0: return "";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
            }

            return "ERROR";

        }
    }
}
