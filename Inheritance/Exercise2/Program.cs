using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise2
{
    class Shape
    {
        private int x, y;

        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                this.x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                this.y = value;
            }
        }

        public virtual string Draw()
        {
            return "Drawing shape at: " + this.x + ", " + this.y;
        }
    }

    class Rectangle : Shape
    {
        private int width, height;

        public Rectangle(int x, int y, int width, int height)
            :base(x, y)
        {
            this.width = width;
            this.height = height;
        }

        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }

        public override string Draw()
        {
            return "Drawing a rectangle at: " + base.X + ", " + base.Y + "\nWidth: " + this.width + "\nHeight: " + this.height;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Shape s1 = new Shape(10, 20);
            Console.WriteLine(s1.Draw());
            Console.WriteLine("---------");
            Rectangle r1 = new Rectangle(30, 40, 10, 20);
            Console.WriteLine(r1.Draw());

            Console.ReadKey();
        }
    }
}
