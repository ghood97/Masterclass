using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Switch1
{
    class Program
    {
        static void Main(string[] args)
        {

            char letter;
            Console.Write("Enter a letter grade: ");
            letter = Char.ToUpper(char.Parse(Console.ReadLine()));
            switch(letter)
            {
                case 'A':
                    Console.WriteLine("90-100");
                    break;
                case 'B':
                    Console.WriteLine("80-89");
                    break;
                case 'C':
                    Console.WriteLine("70-79");
                    break;
                case 'D':
                    Console.WriteLine("60-69");
                    break;
                default:
                    Console.WriteLine("Below 60");
                    break;
            }

            Console.ReadKey();
        }
    }
}
