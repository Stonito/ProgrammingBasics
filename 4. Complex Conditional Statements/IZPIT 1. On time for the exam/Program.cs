using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZPIT_1.On_time_for_the_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minuteOfArrival = int.Parse(Console.ReadLine());
            int hourOfExam = int.Parse(Console.ReadLine());
            int minuteOfExam = int.Parse(Console.ReadLine());

            int exam = hourOfExam * 60 + minuteOfExam;
            int arrival = hourOfArrival * 60 + minuteOfArrival;

            int difference = arrival - exam;

            if(difference > 30)
                Console.WriteLine("Early");
            else if(difference <=30 && difference >=0)
                Console.WriteLine("On time");
            else
                Console.WriteLine("Late");

            if (difference < 60 && difference > 0)
                Console.WriteLine($"{difference} minutes before the start");
            else if (difference >= 60)
            {
                int hours = difference / 60;
                int minutes = difference % 60;
                if (minutes < 10)
                    Console.WriteLine($"{hours}:0{minutes} hours before the start");
                else
                    Console.WriteLine($"{hours}:{minutes} hours before the start");
            }
            else if(difference > -60 && difference < 0)
                Console.WriteLine($"{Math.Abs(difference)} minutes after the start");
            else if (difference <= -60)
            {
                int hours = Math.Abs(difference / 60);
                int minutes = Math.Abs(difference % 60);
                if (minutes < 10)
                    Console.WriteLine($"{hours}:0{minutes} hours after the start");
                else
                    Console.WriteLine($"{hours}:{minutes} hours after the start");
            }

        }
    }
}
