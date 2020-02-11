using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WritingCharactersToAFile
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = "D:\\OneDrive\\Desktop\\C#\\output.txt";
            string path2 = "D:\\OneDrive\\Desktop\\C#\\output2.txt";
            StreamReader inFile = new StreamReader(path);
            StreamWriter outFile = new StreamWriter(path2);

            char ch;
            ch = Convert.ToChar(inFile.Read());
            while(inFile.Peek() != -1)
            {
                outFile.Write(ch);
                ch = Convert.ToChar(inFile.Read());
            }
            outFile.Close();
            inFile.Close();
            Console.WriteLine("Finished.");


            Console.ReadKey();
        }
    }
}
