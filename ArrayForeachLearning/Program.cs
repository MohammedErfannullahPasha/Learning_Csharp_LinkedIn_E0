using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayForeachLearning
{
    class Program
    {
        static void Main(string[] args)
        {

            var studentName = new List<string>();
            var studentGrade = new List<int>();
            bool answer = true;
            while (answer)
            {
                Console.WriteLine("Student_Name : ");
                studentName.Add(Console.ReadLine());

                Console.WriteLine("Student_Grade : ");
                studentGrade.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Do you want to add another student details, Choose Yes/No ?");
                string _answer = Console.ReadLine();
                if (_answer == "Yes")
                {
                    answer = true;
                }
                else if (_answer == "No")
                {
                    answer = false;
                }
                else
                {
                    Console.WriteLine("Please provide defined input");
                }

            }

            for (int i = 0; i < studentName.Count; i++)
            {
                Console.WriteLine("Student_Name : {0} & Student_Grade : {1}", studentName[i], studentGrade[i]);
            }

        }
    }
}
