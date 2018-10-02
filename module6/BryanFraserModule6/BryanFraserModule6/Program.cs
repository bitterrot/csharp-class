using System;

namespace BryanFraserModule6
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Shape();
            Rectangle r1 = new Rectangle();
            s1.SetHeight(11);
            s1.SetWidth(10);
            Console.WriteLine("Height = {0} Width = {1}", s1.GetHeight(), s1.GetWidth());
            r1.setWandH(3, 5);
            Console.WriteLine("Area = {0}", r1.GetArea());
            Console.WriteLine("Hello from Main");
            Console.ReadLine();
        }

        class Shape
        {
            private int width;
            private int height;
            public Shape() { }
            public void SetWidth(int w) { width = w; }
            public void SetHeight(int l) { height = l; }
            public int GetWidth() { return width; }
            public int GetHeight() { return height; }
        }

        class Rectangle : Shape
        {
            public void setWandH(int w, int h)
            {
                SetHeight(h);
                SetWidth(w);
            }
            public int GetArea()
            {
                return (GetHeight() * GetWidth());
            }
        }
    }
}
