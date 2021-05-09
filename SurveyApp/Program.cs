using System;

namespace SurveyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("what is your name ?");
            string Name = Console.ReadLine();

            Name = TryAgain(Name);
            
            Console.WriteLine("what is your age ?");
            string Age = Console.ReadLine();

            Age = TryAgain(Age);

            Console.WriteLine("what month were you born in ?");
            string Month = Console.ReadLine();

            Month = TryAgain(Month);
            
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

        static string TryAgain(string Question)
        {
            while (Question == "")
            {
                Console.WriteLine("Please provide the input, it is mandatory");
                Question = Console.ReadLine();
            }
            return Question;
        }

    }
}
