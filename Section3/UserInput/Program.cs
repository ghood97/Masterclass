using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get input and store into variables
            Console.WriteLine("Enter first number: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter second number: ");
            string str2 = Console.ReadLine();

            // Parse strings to Ints and add
            int num1 = int.Parse(str1);
            int num2 = int.Parse(str2);
            int sum = num1 + num2;
            Console.WriteLine("\n" + num1 + " + " + num2 + " = " + sum);
        }
    }
}
