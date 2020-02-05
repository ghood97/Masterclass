using System;

namespace NestedIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your username: ");
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = Console.ReadLine();

            if(isRegistered)
            {
                Console.WriteLine("Hi there, registered user.");
                if(userName != "")
                {
                    Console.WriteLine("Hello, {0}", userName);
                    if(isAdmin)
                    {
                        Console.WriteLine("Hello, admin.");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
