using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {

            const int rows = 4;
            const int cols = 13;
            int[,] deck = new int[rows, cols];
            InitDeck(deck);
            DisplayDeck(deck);
            Console.WriteLine();
            Shuffle(deck);
            DisplayDeck(deck);

            Console.ReadKey();
        }

        static void InitDeck(int[,] arr)
        {
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 13; col++)
                {
                    arr[row, col] = 0;
                }
            }
        }

        static void DisplayDeck(int[,] arr)
        {
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 13; col++)
                {
                    Console.Write(arr[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Shuffle(int[,] arr)
        {
            int row, col;
            Random rand = new Random();
            for(int card = 1; card <= 52; card++)
            {
                row = rand.Next(4);
                col = rand.Next(13);
                if (arr[row, col] == 0)
                    arr[row, col] = card;
                else
                {
                    while(arr[row, col] != 0)
                    {
                        row = rand.Next(4);
                        col = rand.Next(13);
                    }
                    arr[row, col] = card;
                }
            }
        }
    }
}
