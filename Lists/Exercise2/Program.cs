using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            BuildList(numbers, 20);
            Display(numbers);
            int item;
            Console.Write("Enter an item: ");
            item = Convert.ToInt32(Console.ReadLine());
            List<int> foundItems = new List<int>();
            foundItems = search(numbers, item);
            Display(foundItems);
            for (int i = 0; i < foundItems.Count; i++)
            {
                Console.Write(numbers[foundItems[i]] + " ");
            }
            Console.ReadKey();

        }

        static List<int> search(List<int> lyst, int item)
        {
            int foundAt, pos;
            pos = 0;
            List<int> items = new List<int>();
            foundAt = lyst.IndexOf(item, pos);
            items.Add(foundAt);
            while (foundAt > -1)
            {
                pos = foundAt + 1;
                foundAt = lyst.IndexOf(item, pos);
                if (foundAt > -1)
                    items.Add(foundAt);
            }
            return items;
        }

        static void BuildList(List<int> lyst, int numItems)
        {
            Random rand = new Random();
            for (int i = 1; i <= numItems; ++i)
                lyst.Add(rand.Next(1, 101));
        }

        static void Display(List<int> lyst)
        {
            Console.Write(lyst[0] + " ");
            for (int i = 1; i < lyst.Count; ++i)
                if (i % 25 == 0)
                    Console.WriteLine();
                else
                    Console.Write(lyst[i] + " ");
            Console.WriteLine();
        }

    }
}
