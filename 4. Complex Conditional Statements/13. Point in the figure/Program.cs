using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Point_in_the_figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (((x < 2 * h && x > (2 * h - h)) && (y < 4 * h && y > (4 * h - 3 * h))) || (x > 0 && x < 3 * h) && (y > 0 && y < h) || (y == h && x > h && x < (2 * h)))
            {
                Console.WriteLine("inside");
            }
            else if ((((y == 0 || y == h) && x >= 0 && x <= 3 * h) || ((x == 0 || x == 3 * h) && y >= 0 && y <= h)))
                Console.WriteLine("border");
            else if ((y == 4 * h && x <= 2 * h && x >= (2 * h - h)) || (x == h || x == 2 * h) && y <= 4 * h && y >= h)
                Console.WriteLine("border");
            else
                Console.WriteLine("outside");
        }
    }
}
/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int x1 = 0;
            int y1 = h;
            int x2 = 3 * h;
            int y2 = 0;

            int x3 = h;
            int y3 = 4 * h;
            int x4 = 2 * h;
            int y4 = h;

            bool inR1 = ((x1 < x) && (x < x2) && (y2 < y) && (y < y1));
            bool inR2 = ((x3 < x) && (x < x4) && (y4 < y) && (y < y3));

            bool onX1 = ((x == x1) && ((y <= y1) && (y >= y2)));
            bool onX2 = ((x == x2) && ((y <= y1) && (y >= y2)));
            bool onY1 = ((y == y1) && ((x <= x2) && (x >= x1)));
            bool onY2 = ((y == y2) && ((x <= x2) && (x >= x1)));

            bool onX3 = ((x == x3) && ((y <= y3) && (y >= y4)));
            bool onX4 = ((x == x4) && ((y <= y3) && (y >= y4)));
            bool onY3 = ((y == y3) && ((x <= x4) && (x >= x3)));
            bool onY4 = ((y == y4) && ((x <= x4) && (x >= x3)));


            bool onR1 = onX1 || onX2 || onY1 || onY2;
            bool onR2 = onX3 || onX4 || onY3 || onY4;

            bool union = (y == y1) && ((x > x3) && (x < x4));

            if (inR1 || inR2)
            {
                Console.WriteLine("inside");
            }
            else
            {
                if (onR1 || onR2)
                {
                    if (!union)
                    {
                        Console.WriteLine("border");
                    }
                    else
                        Console.WriteLine("inside");
                }
                else
                {
                    Console.WriteLine("outside");
                }
            }


        }
    }
}
*/