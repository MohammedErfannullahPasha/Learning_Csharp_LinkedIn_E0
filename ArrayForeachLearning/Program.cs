﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayForeachLearning
{
    class Program
    {
        static void Main(string[] args)
        {

            var StudentList = new List<Student>();

            bool answer = true;
            while (answer)
            {
                Student studentObj = new Student();

                Console.WriteLine("Student_Name : ");
                studentObj.Name = Console.ReadLine();

                Console.WriteLine("Student_Grade : ");
                studentObj.Grade = int.Parse(Console.ReadLine());

                Console.WriteLine("Student_Bday : ");
                studentObj.Birthday = Console.ReadLine();

                Console.WriteLine("Student_Address : ");
                studentObj.Address = Console.ReadLine();

                Console.WriteLine("Student_Phone# : ");
                studentObj.Phone = long.Parse(Console.ReadLine());

                Console.WriteLine("Do you want to add another student details, Choose Yes/No ?");
                string _answer = Console.ReadLine();

                if (_answer != "Yes")
                {
                    answer = false;
                }

                StudentList.Add(studentObj);

            }

            foreach (var student in StudentList)
            {
                Console.WriteLine("Student_Name : {0} | Student_Grade : {1} | Student_Bday : {2} | " +
                    "Student_Address : {3} | Student_Phone# : {4} ", student.Name, student.Grade, student.Birthday, student.Address, student.Phone);
            }

        }
    }

    class Student
    {
        public string Name;
        public int Grade;
        public string Birthday;
        public string Address;
        public long Phone;
    }
}
