using System;

namespace SchoolTracker
{
    public class Teacher : Member, IPayee
    {
        public string Subject;
        public void Pay()
        {
            Console.WriteLine("Paying teacher");
        }
    }
}