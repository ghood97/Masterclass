using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WritingDataToFile
{
    class Program
    {
        static void Main(string[] args)
        {

            TextWriter outFile = new StreamWriter("D:\\OneDrive\\Desktop\\C#\\output.txt");
            string line;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter data: ");
                line = Console.ReadLine();
                outFile.WriteLine(line);
            }
            outFile.Close();

            Console.ReadKey();
        }
    }
}
