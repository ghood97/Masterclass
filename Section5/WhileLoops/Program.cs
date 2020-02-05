using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 0;
            while(count < 10)
            {
                Console.WriteLine(count);
                count++;
            }

            Console.ReadKey();
        }
    }
}
