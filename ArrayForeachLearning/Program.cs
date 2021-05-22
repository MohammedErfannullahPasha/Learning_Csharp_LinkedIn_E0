using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayForeachLearning
{
    class Program
    {
        static void Main(string[] args)
        {

            //using the pre-defined student data which is simulated using Import function
            Import();

            var StudentList = new List<Student>();

            bool answer = true;

            while (answer)
            {
                Student studentObj = new Student();

                //Using the Console class from QnA namespace.

                studentObj.Name = QnA.Console.Ask("Student_Name : ");

                studentObj.Grade = int.Parse(QnA.Console.Ask("Student_Grade : "));

                studentObj.Birthday = QnA.Console.Ask("Student_Bday : ");

                studentObj.Address = QnA.Console.Ask("Student_Address : ");

                studentObj.PhoneNumb = long.Parse(QnA.Console.Ask("Student_Phone# : "));

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

        //Let us create method to simulate the import of student data from external resource like spreadhseet.
        //constructing student with pre existing data and that data can be displayed on Console.
        //removing static gives the error when Import() is called from Main method, why ?
        public static void Import()
        {
            Student importStudData = new Student("Erfan", 89, "31 Dec 1993", "Ballari-583104", 9480563943);
            Console.WriteLine(importStudData.Name);
            //importStudData.Grade, importStudData.Birthday, importStudData.Address, importStudData.PhoneNumb
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

        //lets create an empty constructor to bypass and user is able to provide the data for studentObj.
        //this constructor is used for the user to provide the data of student after instance is created.
        public Student()
        {

        }
        //creating a constructor to pass the student data upfront or from spreadsheet.
        //This constructor is used when data is set when we create a student or to import from XLS.
        public Student(string name, int grade, string birthday, string address, long phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;
        }

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
