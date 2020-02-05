using System;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "gooch";
            string password = "abc123";

            Console.Write("Enter your username: ");
            string tryUname = Console.ReadLine();
            Console.Write("Enter your password: ");
            string tryPass = Console.ReadLine();

            if(tryUname == userName && tryPass == password)
            {
                Console.WriteLine("Welcome, {0}{1}", userName, '!');
            }
            else
            {
                Console.WriteLine("Invalid credentials.");
            }


            Console.ReadKey();
        }
    }
}
