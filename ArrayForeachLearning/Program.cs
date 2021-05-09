using System;

namespace ArrayForeachLearning
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Number of students in Class ?");
            var studentCount = int.Parse(Console.ReadLine());

            var studentName = new string[studentCount];
            var studentGrade = new string[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Student_Name : ");
                studentName[i] = Console.ReadLine();

                Console.WriteLine("Student_Grade : ");
                studentGrade[i] = Console.ReadLine();

            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Student_Name : {0} & Student_Grade : {1}", studentName[i], studentGrade[i]);
            }

        }
    }
}
