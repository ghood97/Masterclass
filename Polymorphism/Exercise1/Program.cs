using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise1
{
    class Shape
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

        public virtual string Draw()
        {
            return "Drawing a shape at: " + this.X + ", " + this.Y;
        }
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
                "\nWidth: " + this.Width + ", Height: " + this.Height;
        }
    }

    class Circle : Shape
    {
        private int radius;

        public Circle(int x, int y, int r)
            :base(x, y)
        {
            this.radius = r;
        }

        public override string Draw()
        {
            return "Drawing a circle at: " + this.X + ", " + this.Y + "\nRadius: " + this.radius;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> shapes = new List<Shape>();
            Shape s1 = new Shape(10, 20);
            shapes.Add(s1);
            Rectangle r1 = new Rectangle(1, 1, 10, 15);
            shapes.Add(r1);
            Circle c1 = new Circle(100, 200, 25);
            shapes.Add(c1);
            Rectangle r2 = new Rectangle(200, 300, 20, 30);
            shapes.Add(r2);

            for (int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine(shapes[i].Draw());
            }

            Console.ReadKey();
        }
    }
}
