using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            // LINQ - Language Integrated Query

            Random rand = new Random();
            List<int> grades = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                grades.Add(rand.Next(60, 101));

            }
            foreach (int grade in grades)
            {
                Console.WriteLine(grade + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Grades from high to low\n");
            var orderedGrades =
                from grade in grades
                orderby grade descending
                select grade;
            foreach (var grade in orderedGrades)
            {
                Console.WriteLine(grade);
            }

            Console.WriteLine("Grades greater than 79\n");
            var highGrades =
                from grade in grades
                where grade > 79
                orderby grade ascending
                select grade;
            foreach (var grade in highGrades)
            {
                Console.WriteLine(grade);
            }

            Console.ReadKey();
        }
    }
}
