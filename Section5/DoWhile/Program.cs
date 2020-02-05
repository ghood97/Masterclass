using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            int textLength = 0;
            string wholeText = "";

            do
            {
                Console.Write("Enter the name of a friend: ");
                string name = Console.ReadLine();
                int currentLength = name.Length;
                textLength += currentLength;
                wholeText += name;
            } while (textLength < 20);
            Console.WriteLine("Exiting...");

            Console.ReadKey();
        }
    }
}
