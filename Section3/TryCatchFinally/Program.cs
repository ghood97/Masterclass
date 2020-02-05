using System;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();

            try
            {
                int intInput = int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception: Please only enter integers.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow Exception: Enter a smaller number.");
            }
            catch (Exception)
            {
                Console.WriteLine("General Exception: Try again.");
            }
            finally
            {
                Console.WriteLine("Program is done.");
            }

            Console.ReadKey();
            
        }
    }
}
