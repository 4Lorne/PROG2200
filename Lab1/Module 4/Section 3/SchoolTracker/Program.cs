using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    enum School
    {
        Hogwarts,
        Harvard,
        MIT
    }

    class Program
    {
        static List<Student> students = new List<Student>();
        private static List<IGraduate> graduates = new List<IGraduate>();
        static void Main(string[] args)
        {
            Registrar registrar = new Registrar(new List<IGraduate>(graduates));
            var adding = true;
            Payroll payroll = new Payroll();
            payroll.PayAll();
            

            while (adding)
            {
                try
                {
                    var newStudent = new Student
                    {
                        Name = Util.Console.Ask("Student Name: "),
                        Grade = Util.Console.AskInt("Student Grade: "),
                        School = (School) Util.Console.AskInt("School Name (type the corresponding number): \n 0: Hogwarts High \n 1: Harvard \n 2: MIT \n)"),
                        Birthday = Util.Console.Ask("Student Birthday: "),
                        Address = Util.Console.Ask("Student Address: "),
                        Phone = Util.Console.AskInt("Student Phone Number: ")
                    };

                    students.Add(newStudent);
                    graduates.Add(newStudent);
                    Student.Count++;
                    Console.WriteLine("Student Count: {0}", Student.Count);

                    Console.WriteLine("Add another? y/n");

                    if (Console.ReadLine() != "y")
                        adding = false;
                }
                catch (FormatException msg)
                {
                    Console.WriteLine(msg.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error adding student, Please try again");
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
                registrar.graduateAll();
            }
            Exports();
        }

        static void Import()
        {
            var importedStudent = new Student("Jenny", 86, "birthday", "address", 123456);
            Console.WriteLine(importedStudent.Name);
        }

        static void Exports()
        {
            foreach (var student in students)
            {
                switch(student.School)
                {
                    case School.Hogwarts:
                        Console.WriteLine("Exporting to Hogwarts");
                        break;
                    case School.Harvard:
                        Console.WriteLine("Exporting to Harvard");
                        break;
                    case School.MIT:
                        Console.WriteLine("Exporting to MIT");
                        break;
                }
            }
        }
        
        
        
    }
}
