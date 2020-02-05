using System;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the temperature in farenheit: ");
            string input = Console.ReadLine();
            int temp = int.Parse(input);

            if(temp < 40)
            {
                Console.WriteLine("Wear a jacket.");
            }
            else if(temp < 50)
            {
                Console.WriteLine("Wear pants.");
            }
            else if(temp < 60)
            {
                Console.WriteLine("Wear shorts and a long sleeve shirt.");
            }
            else
            {
                Console.WriteLine("Wear shorts and a t-shirt.");
            }

            Console.ReadKey();
        }
    }
}
