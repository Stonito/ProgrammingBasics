using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZPIT_3.Umnata_Lili
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageOfLilly = int.Parse(Console.ReadLine());
            double priceOfVendingMachine = double.Parse(Console.ReadLine());
            int priceForASingleToy = int.Parse(Console.ReadLine());

            int yearsWithMoney = ageOfLilly / 2;
            double presentMoney = 10;
            double totalMoneyOfLilly = 0;

            for (int i = 0; i < yearsWithMoney; i++)
            {
                totalMoneyOfLilly += presentMoney;
                presentMoney += 10;
            }

            totalMoneyOfLilly -= yearsWithMoney * 1;

            int yearsWithPresent = yearsWithMoney;

            if (ageOfLilly % 2 == 1)
                yearsWithPresent++;

            totalMoneyOfLilly += yearsWithPresent * priceForASingleToy;

            if(totalMoneyOfLilly-priceOfVendingMachine>=0)
                Console.WriteLine("Yes! {0:f2}", totalMoneyOfLilly - priceOfVendingMachine);
            else
                Console.WriteLine("No! {0:f2}", Math.Abs(totalMoneyOfLilly - priceOfVendingMachine));

        }
    }
}
