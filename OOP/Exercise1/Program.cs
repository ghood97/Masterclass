using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise1
{
    class Calculator
    {
        private double result;

        public Calculator()
        {
            result = 0;
        }

        public double Add(double op1, double op2)
        {
            result = op1 + op2;
            return result;
        }

        public double Subtract(double op1, double op2)
        {
            result = op1 - op2;
            return result;
        }

        public double Product(double op1, double op2)
        {
            result = op1 * op2;
            return result;
        }

        public double Divide(double op1, double op2)
        {
            result = op1 / op2;
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Calculator calc = new Calculator();
            Console.WriteLine(calc.Add(3, 6));
            Console.WriteLine(calc.Subtract(10, 5));
            Console.WriteLine(calc.Product(12, 12));
            Console.WriteLine(calc.Divide(100, 5));

            Console.ReadKey();
        }
    }
}
