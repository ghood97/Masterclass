using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------------");

            for(int i = 0; i<=50; i += 5)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------------");

            for (int i = 0; i <= 20; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
