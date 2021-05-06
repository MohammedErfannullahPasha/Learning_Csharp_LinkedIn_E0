using System;

namespace SurveyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string passcode = "secret";
            Console.WriteLine("Please provide the passcode");

            if (passcode == Console.ReadLine())
            {
                Console.WriteLine("what is your name ?");
                string Name = Console.ReadLine();
                Console.WriteLine("what is your age ?");
                string Age = Console.ReadLine();
                Console.WriteLine("what month were you born in ?");
                string Month = Console.ReadLine();
                Console.WriteLine("Hi {0}! Since you were born in {1} and your " +
                    "age is {2}", Name, Month, Age);

                if (Month == "December")
                {
                    string Zodiac = "capricorn";
                    Console.WriteLine(Zodiac);
                }
                else if (Month == "August")
                {
                    string Zodiac = "Leo";
                    Console.WriteLine(Zodiac);
                }
                else if (Month == "April")
                {
                    string Zodiac = "Aries";
                    Console.WriteLine(Zodiac);
                }
                                
            }
            else
            {
                Console.WriteLine("Wrong passcode, Please Exit !");
            }
        }
    }
}
