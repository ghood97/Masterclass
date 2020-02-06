using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractClasses
{
    class Program
    {
        abstract class Shape
        {
            private int x, y;

            public Shape(int newx, int newy)
            {
                x = newx;
                y = newy;
            }

            public int X
            {
                get
                {
                    return x;
                }
                set
                {
                    x = value;
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
                    y = value;
                }
            }

            abstract public string Draw();
        }

        class Rectangle : Shape
        {
            private int width, height;

            public Rectangle(int newx, int newy, int newHeight, int newWidth) :
                base(newx, newy)
            {
                height = newHeight;
                width = newWidth;
            }

            public int Height
            {
                get
                {
                    return height;
                }
                set
                {
                    height = value;
                }
            }

            public int Width
            {
                get
                {
                    return width;
                }
                set
                {
                    width = value;
                }
            }

            public override string Draw()
            {
                return "Drawing a rectangle at: " + base.X + ", " + base.Y +
                    " Width: " + this.Width + ", Height: " + this.Height;
            }
        }
        static void Main(string[] args)
        {

            

            Console.ReadKey();
        }
    }
}
