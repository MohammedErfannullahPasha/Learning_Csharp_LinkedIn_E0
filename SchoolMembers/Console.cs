using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnA
{
    class Console
    {
        public static string Ask(string question)
        {
            System.Console.Write(question);
            return System.Console.ReadLine();
        }

        //Method Overloading : lets overload Ask function by taking different data type of parameter
        
        public static string Ask(int question)
        {
            System.Console.Write(question);
            return System.Console.ReadLine();
        }

        public static int AskInt(string question)
        {
            try
            {
                System.Console.Write(question);
                return int.Parse(System.Console.ReadLine());
            }
            catch(Exception)
            {
                throw new FormatException("invalid Input - string input cannot be converted to int. Please provide correct value");
            }

        }

        public static long AskLong(string question)
        {
            System.Console.Write(question);
            return long.Parse(System.Console.ReadLine());
        }

    }
}
