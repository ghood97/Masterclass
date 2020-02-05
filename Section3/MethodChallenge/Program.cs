using System;

namespace MethodChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string f1 = "Brian";
            string f2 = "Mike";
            string f3 = "Anthony";
            GreetFriend(f1);
            GreetFriend(f2);
            GreetFriend(f3);

        }

        public static void GreetFriend(string name)
        {
            Console.WriteLine("Hello, {0}", name);
        }
    }
}
