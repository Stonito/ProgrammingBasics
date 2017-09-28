using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            if (str == "s3cr3t!P@ssw0rd")
                Console.WriteLine("Welcome");
            else
                Console.WriteLine("Wrong password!");

        }
    }
}
