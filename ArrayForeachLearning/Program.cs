using System;

namespace ArrayForeachLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentGrades = new int[] { 98, 96, 67, 34, 56, 79, 100, 88 };
            foreach (var studentGrade in studentGrades)
            {
                Console.WriteLine(studentGrade);
            }

        }
    }
}
