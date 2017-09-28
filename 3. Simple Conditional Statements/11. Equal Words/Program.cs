using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string duma1 = Console.ReadLine();
            string duma2 = Console.ReadLine();

            duma1 = duma1.ToLower();
            duma2 = duma2.ToLower();


            if (duma1==duma2)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
}
