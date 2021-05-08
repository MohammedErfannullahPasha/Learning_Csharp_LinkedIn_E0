using System;

namespace Loop_Counting
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 1;
            
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
            i--;
            while (i > 0)
            {
                Console.WriteLine(i);
                i--;
            }
            i++;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
            i--;
            while (i > 0)
            {
                Console.WriteLine(i);
                i--;
            }
            i++;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.ReadLine();
        }
    }
}
