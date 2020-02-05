using System;

namespace Challenge2
{
    class Program
    {
        static int highScore = 37000;
        static string highPlayer = "Gooch";
        static void Main(string[] args)
        {

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your score: ");
            int score = int.Parse(Console.ReadLine());
            checkWinner(score, name);

            Console.ReadKey();
        }

        public static void checkWinner(int score, string player)
        {
            if(score > highScore)
            {
                Console.WriteLine("New highscore is " +  score);
                Console.WriteLine("New highscore holder is " + player);
            }
            else
            {
                Console.WriteLine("The old highscore of " + highScore + " could not be broken and is still held by " + highPlayer);
            }
        }
    }
}
