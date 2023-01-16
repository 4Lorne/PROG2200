using System;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students in your class?");
            var studentCount = int.Parse(Console.ReadLine());

            var studentArray = new string[studentCount, 2];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write("Student Name: ");
                studentArray[i, 0] = Console.ReadLine();
                
                Console.Write("Student Grade: ");
                studentArray[i, 1] = Console.ReadLine();
            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", studentArray[i,0], studentArray[i,1]);
            }
        }
    }
}
