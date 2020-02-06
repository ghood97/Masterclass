using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    public interface Shape
    {
        void SetX(int x);
        void SetY(int y);
        int GetX();
        int GetY();
        void Move(int x, int y);
        void Draw();
    }

    public class Rectangle : Shape
    {
        int x, y, width, height;

        public Rectangle(int x, int y, int h, int w)
        {
            this.x = x;
            this.y = y;
            this.height = h;
            this.width = w;
        }

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }

        public void SetX(int x)
        {
            this.x = x;
        }

        public void SetY(int y)
        {
            this.y = y;
        }

        public void Move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a rectangle at: " + this.x + ", " + this.y);
            Console.WriteLine("Width: " + this.width + "\nHeight: " + this.height);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {



            Console.ReadKey();
        }
    }
}
