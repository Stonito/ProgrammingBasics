using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            string format = "dd-MM-yyyy";
            DateTime dateAfter1000days = DateTime.ParseExact(date, format, System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine(dateAfter1000days.AddDays(999).ToString(format));
          
        }
    }
}
