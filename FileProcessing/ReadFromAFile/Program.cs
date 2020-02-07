using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ReadFromAFile
{
    class Program
    {
        static void Main(string[] args)
        {

            //TextReader inFile = new StreamReader("D:\\OneDrive\\Desktop\\C#\\output.txt");
            //string data;
            //while (inFile.Peek() != -1)
            //{
            //    data = inFile.ReadLine();
            //    Console.WriteLine(data);
            //}
            //inFile.Close();
            string filePath = "D:\\OneDrive\\Desktop\\C#\\grades.txt";
            TextWriter outFile = new StreamWriter(filePath);
            int grade;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Enter a grade: ");
                grade = int.Parse(Console.ReadLine());
                outFile.WriteLine(grade);
            }
            outFile.Close();
            TextReader inFile = new StreamReader(filePath);
            double average = 0.0;
            int total =0;
            int count = 0;
            while(inFile.Peek() != -1)
            {
                grade = int.Parse(inFile.ReadLine());
                total += grade;
                ++count;
            }
            inFile.Close();
            average = total / count;
            Console.WriteLine("Average: " + average); ;

            Console.ReadKey();
        }
    }
}
