using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var exception = new MyCustomException();
            var students = new List<Student>();

            var adding = true;
            
                while (adding)
                {
                    var newStudent = new Student();
                    var grade = String.Empty;
                    newStudent.Name = Util.Console.Ask("Student Name: ");
                    
                    try
                    {
                        Console.WriteLine("Student Grade: ");
                        grade = Console.ReadLine();
                        int parsedGrade = Int32.Parse(grade);
                        newStudent.Grade = parsedGrade;

                    }
                    catch
                    {
                        Console.WriteLine(exception.ToString());
                    }
                    
                    newStudent.Birthday = Util.Console.Ask("Student Birthday: ");

                    newStudent.Address = Util.Console.Ask("Student Address: ");

                    newStudent.Phone = int.Parse(Util.Console.Ask("Student Phone Number: "));

                    students.Add(newStudent);
                    Student.Count++;
                    Console.WriteLine("Student Count: {0}", Student.Count);

                    Console.WriteLine("Add another? y/n");

                    if (Console.ReadLine() != "y")
                        adding = false;
                }

                foreach (var student in students)
                {
                    Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
                }
            
            
        }

        static void Import()
        {
            var importedStudent = new Student("Jenny", 86, "birthday", "address", 123456);
            Console.WriteLine(importedStudent.Name);
        }
    }

    class Member
    {
        public string Name;
        public string Address;
        protected int phone;

        public int Phone
        {
            set { phone = value; }
        }
    }

    class Student : Member
    {
        static public int Count = 0;

        public int Grade;
        public string Birthday;

        public Student()
        {

        }

        public Student(string name, int grade, string birthday, string address, int phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;
        }
    }

    class Teacher : Member
    {
        public string Subject;
    }
}
