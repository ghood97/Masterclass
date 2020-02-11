using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            //int num, denom;
            //num = 12;
            //denom = 0;

            //try
            //{
            //    Console.WriteLine(num / denom);
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.Write("Enter a non-zero denominatior: ");
            //    denom = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(num / denom);
            //}

            StreamReader inFile;
            string fileName;
            Console.Write("Enter a file name: ");
            fileName = Console.ReadLine();
            try
            {
                inFile = new StreamReader(fileName);
            }
            catch (FileNotFoundException e)
            {

                Console.WriteLine(e.Message);
                Console.Write("Enter a new filename: ");
                fileName = Console.ReadLine();
                inFile = new StreamReader(fileName);
            }
            Console.WriteLine(inFile.ReadLine());

            Console.ReadKey();
        }
    }
}
