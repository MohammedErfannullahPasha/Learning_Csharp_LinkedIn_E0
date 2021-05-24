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

        public static int AskInt(string question)
        {
            System.Console.Write(question);
            return int.Parse(System.Console.ReadLine());
        }

        public static long AskLong(string question)
        {
            System.Console.Write(question);
            return int.Parse(System.Console.ReadLine());
        }

    }
}
