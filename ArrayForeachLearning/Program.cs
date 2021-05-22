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
                studentObj.PhoneNumb = long.Parse(Console.ReadLine());

                //calling count using Student class, we cannot call Count using its instance "studentObj".
                Student.Count++;
                Console.WriteLine("Student Reg No : {0}", Student.Count);

                Console.WriteLine("Do you want to add another student details, Choose Yes/No ?");
                string _answer = Console.ReadLine();

                if (_answer != "Yes")
                {
                    answer = false;
                }

                StudentList.Add(studentObj);

            }

            Console.WriteLine("Total Number of Students : {0}", Student.Count);

            foreach (var student in StudentList)
            {
                Console.WriteLine("Student_Name : {0} | Student_Grade : {1} | Student_Bday : {2} | " +
                    "Student_Address : {3} | Student_Phone# : {4} ", student.Name, student.Grade, student.Birthday, student.Address, student.PhoneNumb);
            }

        }
    }

    class Student
    {

        //1. adding static variable to count the class of student, even if we have 10 students but we will only have 
        //one count to worry about.
        //2. Static field is shared accross all instances of students.
        public static int Count = 0;
        public string Name;
        public int Grade;
        public string Birthday;
        public string Address;
        private long Phone;

        //setting the value using method but cannot get the value from line61 to line 49

        public long PhoneNumb
        {
            set
            {
                Phone = value;
            }
            //without get accessor, we cannot call PhoneNumb using dot operator in another class.
            get
            {
                return Phone;
            }
        }

        //public void setPhone(long number)
        //{
        //    Phone = number;
        //}
    }
}
