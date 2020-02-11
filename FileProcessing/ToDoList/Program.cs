using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ToDoList
{
    class Program
    {
        static string fileName = "D:\\OneDrive\\Desktop\\C#\\Masterclass\\FileProcessing\\ToDoList\\todolist.txt";
        static void Main(string[] args)
        {

            int menuItem = -1;
            while(menuItem != 0)
            {
                menuItem = Menu();
                switch (menuItem)
                {
                    case 1:
                        ShowList();
                        break;
                    case 2:
                        AddItem();
                        break;
                    case 3:
                        RemoveItem();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Unrecognized command.");
                        break;
                }
            }

        }

        static int Menu()
        {
            int choice;
            Console.WriteLine("Main Menu\n");
            Console.WriteLine("0 - Exit the proram");
            Console.WriteLine("1 - Display to-do list");
            Console.WriteLine("2 - Add item to list");
            Console.WriteLine("3 - Remove item from list");
            Console.WriteLine();
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        static void ShowList()
        {
            Console.WriteLine("\nTo-do List\n");
            StreamReader inFile = new StreamReader(fileName);
            string line;
            int number = 1;
            while(inFile.Peek() != -1)
            {
                line = inFile.ReadLine();
                Console.Write(number + ": ");
                Console.WriteLine(line);
                number++;
            }
            Console.WriteLine();
            inFile.Close();
        }

        static void AddItem()
        {
            Console.WriteLine("\nAdd Item\n");
            StreamWriter outFile = File.AppendText(fileName);
            Console.Write("Enter an item: ");
            outFile.WriteLine(Console.ReadLine());
            outFile.Close();
        }

        static void RemoveItem()
        {
            int choice;
            ShowList();
            Console.Write("Which item do you want to remove?: ");
            choice = Convert.ToInt32(Console.ReadLine());

            List<string> items = new List<string>();
            int number = 1;
            string item;
            StreamReader inFile = new StreamReader(fileName);
            while(inFile.Peek() != -1)
            {
                item = inFile.ReadLine();
                if(number != choice)
                {
                    items.Add(item);
                }
                number++;
            }
            inFile.Close();
            StreamWriter outFile = new StreamWriter(fileName);
            for (int i = 0; i < items.Count; i++)
            {
                outFile.WriteLine(items[i]);
            }
            outFile.Close();
        }
    }
}
