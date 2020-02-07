using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayAccess
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            int[] numbers = new int[10];
            Random rand = new Random();
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = rand.Next(1, 101);

            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine(numbers[i]);

            Console.ReadKey();
        }
    }
}
