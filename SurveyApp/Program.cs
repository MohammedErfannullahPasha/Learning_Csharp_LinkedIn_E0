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
        //declaring or creating an event
        static public event Action Posted;

        static void Main(string[] args)
        {
            //calling the method to display the message once the event is received by subscriber
            var stats = new Stats();
            stats.Start();

            Data data = new Data();

            Console.WriteLine("what is your name ?");
            data.Name = TryAgain();

            Console.WriteLine("what is your age ?");
            data.Age = int.Parse(TryAgain());

            Console.WriteLine("what month were you born in ?");
            data.Month = TryAgain();

            //event will trigger when all the details are provided.
            Posted();

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
