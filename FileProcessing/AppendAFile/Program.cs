using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AppendAFile
{
    class Program
    {
        static void Main(string[] args)
        {

            TextWriter outFile = File.AppendText("D:\\OneDrive\\Desktop\\C#\\output.txt");
            outFile.WriteLine("Hello1");
            outFile.WriteLine("Hello2");
            outFile.WriteLine("Hello3");
            outFile.Close();

            StreamReader inFile = new StreamReader("D:\\OneDrive\\Desktop\\C#\\output.txt");
            try
            {
                string line;
                while (inFile.Peek() != -1)
                {
                    line = inFile.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                inFile.Close();
            }

            Console.ReadKey();
        }
    }
}
