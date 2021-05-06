using System;

namespace SurveyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a survey application//
            Console.WriteLine("what is your name ?");
            string Name = Console.ReadLine();
            Console.WriteLine("what is your age ?");
            string Age = Console.ReadLine();
            Console.WriteLine("what month were you born in ?");
            string Month = Console.ReadLine();

            Console.WriteLine("Hi {0}! Since you were born in {1} and your " +
                "age is {2}. you are elligible", Name,Month,Age);
        }
    }
}
