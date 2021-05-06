using System;

namespace AuthenticationPasscode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is the passcode ?");
            var passcode = Console.ReadLine();
            if (passcode == "secret")
            {
                Console.WriteLine("you are Authenticated");
            }
            else
            {
                Console.WriteLine("Invalid passcode");
            }

        }
    }
}
