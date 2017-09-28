using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                int points = 0;
                switch (word[i])
                {
                    case 'a':
                        points = 1;
                        break;
                    case 'e':
                        points = 2;
                        break;
                    case 'i':
                        points = 3;
                        break;
                    case 'o':
                        points = 4;
                        break;
                    case 'u':
                        points = 5;
                        break;
                    default:
                        break;
                }
                sum += points;
            }
            Console.WriteLine(sum);
        }
    }
}
