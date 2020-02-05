using System;
using System.Collections.Generic;

namespace DeclaringAndInitializing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> letters = new List<char>();
            List<int> numbers = new List<int>() {1,2,3,4,5,6,7,8,9,10};
            Console.WriteLine(numbers.Count);

            Console.ReadKey();
        }
    }
}
