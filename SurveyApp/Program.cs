using System;

namespace SurveyApp
{
    
    public class Data
    {
        public string Name;
        public int Age;
        public string Month;

        public void Display()
        {
            Console.WriteLine("Hi {0}! Since you were born in {1} and your age is {2}", Name, Month, Age);

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
    }

    
    class Program
    {
        static void Main(string[] args)
        {

            Data data = new Data();

            Console.WriteLine("what is your name ?");
            data.Name = TryAgain();

            Console.WriteLine("what is your age ?");
            data.Age = int.Parse(TryAgain());

            Console.WriteLine("what month were you born in ?");
            data.Month = TryAgain();

            data.Display();
            

            static string TryAgain()
            {
                string answer = Console.ReadLine();

                while (answer == "")
                {
                    Console.WriteLine("Please provide the input, it is mandatory");
                    answer = Console.ReadLine();
                }
                return answer;
            }
        }

    }

}
