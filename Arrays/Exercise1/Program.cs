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

            Random rand = new Random();
            int num;
            const int size = 101;
            int[] numbers = new int[size];
            for (int i = 1; i < size; ++i)
            {
                num = rand.Next(1, 101);
                numbers[num]++;
            }
            int stars = 0;
            for (int i = 1; i < numbers.Length; ++i)
            {
                stars = numbers[i];
                Console.Write(i + ": ");
                for (int j = 0; j < stars; j++)
                    Console.Write('*');
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
