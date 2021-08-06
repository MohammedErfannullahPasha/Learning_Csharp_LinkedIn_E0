using System;

namespace GeometryTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Geometry Tool");
            var square = new Square() { Side = 2 };
            var triangle = new Triangle() { Height = 2, Width =5 };

            Console.WriteLine(square.GetArea());
            Console.WriteLine(triangle.GetArea());
        
        
        
        }
    }

    class Square
    {
        public int Side;

        public int GetArea()
        {
            return Side * Side;
        }
    }

    class Triangle
    {
        public int Height, Width;

        public int GetArea()
        {
            return Height * Width / 2;
        }
    }

}
