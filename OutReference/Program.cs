using System;

namespace OutReference
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            
            Console.WriteLine(x);
            
            five(out x);

            //now, x is referencing towards variable "a" so the value provided by next line is 5

            Console.WriteLine(x);
        }

        //method that makes any value passed to parameter to value 5
        //to pass value 5 to the variable x, we need to reference variable "a" to x by using out keyword

        public static void five (out int a)
        {
            a = 5;
            Console.WriteLine(a);
        }

    }
}
