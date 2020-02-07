using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random rand = new Random();
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = rand.Next(1, 101);
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
                sum += numbers[i];
            for (int i = 0; i < numbers.Length; i++)
                Console.Write(numbers[i] + " ");
            Console.WriteLine("\n");
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Sum: " + numbers.Sum());
            Console.WriteLine("Average: " + numbers.Average());

            Console.ReadKey();
        }
    }
}
