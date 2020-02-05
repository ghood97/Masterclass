using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsAsArguments
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> grades = new List<int>() { 50, 60, 70, 80, 90, 100 };
            DisplayList(grades);
            Console.WriteLine("----------");
            Console.WriteLine("Average: " + average(grades));
            Console.WriteLine("----------Add 5");
            curveGrades(grades);
            DisplayList(grades);
            Console.WriteLine("----------");
            Console.WriteLine("Average: " + average(grades));

            Console.ReadKey();
        }

        static void DisplayList(List<int> lyst)
        {
            for (int i = 0; i < lyst.Count; i++)
            {
                Console.WriteLine(lyst[i]);
            }
        }

        static double average(List<int> lyst)
        {
            int sum = lyst.Sum();
            return sum / lyst.Count;
        }

        static void curveGrades(List<int> lyst)
        {
            for (int i = 0; i < lyst.Count; i++)
            {
                lyst[i] += 5;
            }
        }
    }
}
