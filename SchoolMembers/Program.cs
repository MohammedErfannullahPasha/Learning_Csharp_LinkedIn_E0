using System;
using System.Collections;
using System.Collections.Generic;

namespace SchoolMember
{
    enum Eschool
    {
        Vianney_Vidyalaya = 0,
        Kadapa_Girls_School = 1,
        Kendriya_vidyalaya = 2
    }

    class Program
    {
        
        static List<Student> StudentList = new List<Student>();

        static void Main(string[] args)
        {
            //not passing input for priority as 1 is default set.
            //not passing any argument to System as it is set to SchoolMember Main as optional argument
            Logger.Log("Tracker has Started");

            PayRoll payroll = new PayRoll();
            payroll.PayAll();
            
            bool answer = true;

            while (answer)
            {
                
                try
                {

                    Student studentObj = new Student();

                    //Using the Console class from QnA namespace.

                    studentObj.Name = QnA.Console.Ask("Student_Name : ");

                    studentObj.Grade = QnA.Console.AskInt("Student_Grade : ");

                    studentObj.Birthday = QnA.Console.Ask("Student_Bday : ");

                    //cannot be converted to int implicitly, so need to parse or explicitly convert to Eschool enum index values
                    studentObj.schoolname = (Eschool) QnA.Console.AskInt("Please select school name from the list : \n " +
                        "(0) : Vianney Vidyalaya \n (1) : Kadapa Girls School \n (2) : Kendriya vidyalaya \n");

                    studentObj.Address = QnA.Console.Ask("Student_Address : ");

                    studentObj.Phone = QnA.Console.AskLong("Student_Phone# : ");

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

                //INTERCHANGING THE BELOW CATCH WILL MAKE FormatExcpetion deprecated.

                catch(FormatException msgVariable)
                {
                    //afterf catching the exeception this block is executed
                    //as soon as the exception is thrown at line 28 & 39 due to incorrect input i.e., string value, the program jumps to catch.
                    Console.WriteLine(msgVariable.Message);
                }

            }

            Console.WriteLine("Total Number of Students : {0}", Student.Count);

            //we need to pass the value as the hardcode is removed.
            ShowGrade("Bubbly");

            foreach (var student in StudentList)
            {
                Console.WriteLine("Student_Name : {0} | Student_Grade : {1} | Student_Bday : {2} | School_Name : {5} |" +
                    "Student_Address : {3} | Student_Phone# : {4} ", student.Name, student.Grade, student.Birthday, student.Address, student.Phone, student.schoolname);
            }

            Export();

            Logger.Log("Exported Data to External source","Import Method",2);

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

        public static void Export()
        {
            foreach (var student in StudentList)
            {
                switch(student.schoolname)
                {
                    case Eschool.Vianney_Vidyalaya:
                        Console.WriteLine("Exporting to Vianney Vidyalaya");
                        break;
                    case Eschool.Kadapa_Girls_School:
                        Console.WriteLine("Exporting to Kadapa Girls School");
                        break;
                    case Eschool.Kendriya_vidyalaya:
                        Console.WriteLine("Exporting to Kendriya vidyalaya");
                        break;
                }
            }
        }

        //lets create a search functionality i.e., grade of student is shown when searched with student name
        //will use Find method from collections and to use it we should createa predicate method
        //predicate method will always return the bool and in this case, it will return true if student is found

        //Now rather passing predicate method into ShowGrade method. we can use Lambda Expression to refactor and reduce the effort.
        //also we no longer need to define any method type to use in lanba expression and this makes lambda Anonymous types.
         
        public static void ShowGrade(string name)
        
        {
            //Entire Predicate function is inside the Find method.
            //lets condense the lambda Expression by passing value to Find method.

            var found = StudentList.Find(student => student.Name == name);

            Console.WriteLine("{0}'s Grade is : {1}", found.Name, found.Grade);
        }

        /* we no longer need the predicate function
        public static bool predicate(Student student)
        {
            //refactorng code
            return (student.Name == "Bubbly");

        }
        */
    }

    class MemberOfSchool
    {
        //Replacing field with property. just add getter and setter & remove semi colon at the end.
        
        public string Name { get; set; }
        public string Address { get; set; }
        //private access specifier makes member to be accessible within same class only, Since Phone
        //field is inherited by other classes, wes should use protected access modifier.
        
        //changing protected field to public
        public long Phone { get; set; }
        
        //below PhoneNumb property does not need or rely on private/protected property,
        //becasue the above Phone property auto implements in background.
        
        /*public long PhoneNumb
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
        }*/

    }

    class Student : MemberOfSchool

    {

        public static int Count { get; set; } = 0;
        public int Grade;
        public string Birthday;
        public Eschool schoolname;

        public Student()
        {

        }

        public Student(string name, int grade, string birthday, string address, long phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;
        }
    }
}
