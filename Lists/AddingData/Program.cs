using System;
using System.Collections.Generic;

namespace AddingData
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            for (int i = 0; i < 100; i++)
            {
                numbers.Add(i);
            }

            Console.ReadKey();
        }
    }
}
