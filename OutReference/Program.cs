using System;

namespace OutReference
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            
            Console.WriteLine(x);
            
            five(x);

            Console.WriteLine(x);
        }

        //method that makes any value passed to parameter to value 5
        public static void five (int a)
        {
            a = 5;
            Console.WriteLine(a);
        }

    }
}
