using System;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learning Anonymous Types");

            //below is the synctax of creating Anonymous type and it is really usefull
            //when you need for temporary purpose and when you dont need to create a class

            var Anonymoustype = new { Name = "Mohammed Erfannullah Pasha", age = 27 };

            Console.WriteLine("Hi {0}, Your age is {1}", Anonymoustype.Name, Anonymoustype.age);

        }
    }
}
