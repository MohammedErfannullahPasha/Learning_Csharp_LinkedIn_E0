using System;

namespace UnderstandThisKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Understanding This Keyword");
            
            Display d1 = new Display(10, 20, 30); //this will flow into instance variables
            d1.DisplayVariables(1,2,3); //this will flow in method parameter variables

        }
    }

    class Display
    {
        int a, b, c; //instance variables. to use instance variables in method, we must use this keyword.

        public Display(int a, int b, int c)  //these are parameter variables
        {
            //LHS are instance variables and RHS are paramter variables
            this.a = a; //10
            this.b = b; //20
            this.c = c; //30

        }

        public void DisplayVariables(int a, int b, int c) //1,2,3
        {
            Console.WriteLine(a + "\t" + b + "\t" + c); //1,2,3
            Console.WriteLine(this.a + "\t" + this.b + "\t" + this.c); //10,20,30
        }
    }
}
