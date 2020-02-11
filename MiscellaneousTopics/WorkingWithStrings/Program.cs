using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            string sentence = "This is a string";
            char[] delimiter = new char[1] { ' ' };
            string[] words = sentence.Split(delimiter);
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            Console.ReadKey();
        }
    }
}
