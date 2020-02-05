using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("Something specific");
            Console.WriteLine(Add(2, 3));
        }

        public static void WriteSomething()
        {
            // cant call function from another static function unless it is staic itself
            Console.WriteLine("I am called from a method.");
        }

        public static void WriteSomethingSpecific(string str)
        {
            Console.WriteLine(str);
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
