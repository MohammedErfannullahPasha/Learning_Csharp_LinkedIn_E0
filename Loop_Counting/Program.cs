using System;

namespace Loop_Counting
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int repeat = 1; repeat <= 5 ; repeat++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
                for (int i = 10; i >=1 ; i--)
                {
                    Console.WriteLine(i);
                }
            }
            
            Console.ReadLine();
        }
    }
}
