using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string town = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            double price = -1.0;

            string sofia = "sofia";
            string plovdiv = "plovdiv";
            string varna = "varna";

            string coffee = "coffee";
            string water = "water";
            string beer = "beer";
            string sweets = "sweets";
            string peanuts = "peanuts";

            if (town==sofia)
            {
                if (product == coffee)
                    price = 0.5;
                else if (product == water)
                    price = 0.8;
                else if (product == beer)
                    price = 1.2;
                else if (product == sweets)
                    price = 1.45;
                else if (product == peanuts)
                    price = 1.6;
            }
            else if (town==plovdiv)
            {
                if (product == coffee)
                    price = 0.4;
                else if (product == water)
                    price = 0.7;
                else if (product == beer)
                    price = 1.15;
                else if (product == sweets)
                    price = 1.3;
                else if (product == peanuts)
                    price = 1.5;
            }
            else if (town==varna)
            {
                if (product == coffee)
                    price = 0.45;
                else if (product == water)
                    price = 0.7;
                else if (product == beer)
                    price = 1.1;
                else if (product == sweets)
                    price = 1.35;
                else if (product == peanuts)
                    price = 1.55;
            }
            Console.WriteLine("{0}", price*quantity);
        }
    }
}
