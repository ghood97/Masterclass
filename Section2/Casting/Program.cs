using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            double myDouble = 13.37;
            int myInt;

            // cast double to int (explicit)
            myInt = (int)myDouble;
            Console.WriteLine(myInt);

            // implicit
            int num = 12345;
            long big = num;
            Console.WriteLine(big);

            // type conversion
            double d3 = 123.23;
            string str = d3.ToString();
            Console.WriteLine(str[3]); // .

            // with bool
            bool test = true;
            Console.WriteLine(test.ToString());

            // parse string to int
            string myStr = "15";
            string myStr2 = "13";
            Console.WriteLine(Int32.Parse(myStr) + Int32.Parse(myStr2));
        }
    }
}
