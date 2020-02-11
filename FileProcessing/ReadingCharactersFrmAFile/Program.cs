using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ReadingCharactersFrmAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\OneDrive\\Desktop\\C#\\output.txt";

            TextWriter outFile = new StreamWriter(path);
            string line = "Line to write";
            outFile.WriteLine(line);
            outFile.Close();

            StreamReader inFile = new StreamReader(path);
            string words = "";
            char letter;
            while(inFile.Peek() != -1)
            {
                letter = Convert.ToChar(inFile.Read());
                Console.WriteLine(letter);
                words += letter;
            }
            Console.WriteLine(words);

            Console.ReadKey();
        }
    }
}
