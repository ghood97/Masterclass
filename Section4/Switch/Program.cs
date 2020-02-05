using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How old are you?: ");
            int age = int.Parse(Console.ReadLine());

            switch(age)
            {
                case 15:
                    Console.WriteLine("Too young.");
                    break;
                case 25:
                    Console.WriteLine("Old enough.");
                    break;
                default:
                    Console.WriteLine("I'm not sure.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
