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

            //Console.WriteLine(square.GetArea());
            //Console.WriteLine(triangle.GetArea());
            
            square.DisplayArea();
            triangle.DisplayArea();
        
        }
    }

    //abstract is similar to class between normal class and interface.
    //here, we will connnect 2 different class which has commom method by abstract class
    abstract class Shape
    {

        //creating abstract method
        public abstract int GetArea();

        //below such funtion can be implemented in abstract class but not in interface.
        public void DisplayArea()
        {
            Console.WriteLine("Area of the Shape is {0}", GetArea());
        }

    }

    class Square : Shape
    {
        public int Side;

        //abstract method makes madatory to implement getarea method.
        public override int GetArea()
        {
            return Side * Side;
        }
    }

    class Triangle : Shape
    {
        public int Height, Width;

        //abstract method makes madatory to implement getarea method.
        public override int GetArea()
        {
            return Height * Width / 2;
        }
    }

}
