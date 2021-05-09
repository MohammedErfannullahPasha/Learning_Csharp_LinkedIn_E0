using System;

namespace SurveyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("what is your name ?");
            string Name = Console.ReadLine();

            while (Name == "")
            {
                Name = TryAgain();
            }

            Console.WriteLine("what is your age ?");
            string Age = Console.ReadLine();

            while (Age == "")
            {
                Age = TryAgain();
            }

            Console.WriteLine("what month were you born in ?");
            string Month = Console.ReadLine();

            while (Month == "")
            {
                Month = TryAgain();
            }

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

        static string TryAgain()
        {
            Console.WriteLine("Please provide the input, it is mandatory");
            return Console.ReadLine();
        }

    }
}
