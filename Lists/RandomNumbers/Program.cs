using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            List<int> numbers = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                numbers.Add(rand.Next(1, 101));
            }
            Display(numbers);

            Console.ReadKey();
        }

        static void Display(List<int> lyst)
        {
            for (int i = 0; i < lyst.Count; i++)
            {
                if(i % 25 == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(lyst[i] + " ");
                }
            }
        }
    }
}
