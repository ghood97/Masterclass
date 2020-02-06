using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>();
            BuildList(numbers);
            Console.WriteLine("The maximum value is " + Maximum(numbers));

            Console.ReadKey();
        }

        static int Maximum(List<int> lyst)
        {
            int max = 0;
            for (int i = 1; i < lyst.Count; i++)
            {
                if (lyst[i] > lyst[max])
                    max = i;
            }
            return lyst[max];
        }

        static void BuildList(List<int> lyst)
        {
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                lyst.Add(rand.Next(1, 101));
            }
        }

        static void Display(List<int> lyst)
        {
            for (int i = 0; i < lyst.Count; i++)
            {
                if (i % 25 == 0)
                    Console.WriteLine();
                else
                    Console.Write(lyst[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
