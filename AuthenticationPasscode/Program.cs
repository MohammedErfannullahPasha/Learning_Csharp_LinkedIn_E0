﻿using System;

namespace AuthenticationPasscode
{
    class Program
    {
        static void Main(string[] args)
        {

            var passcode = "" ;
            while (passcode != "secret")

            {
                Console.WriteLine("what is the passcode ?");

                passcode = Console.ReadLine();

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
}