using System;

namespace SchoolTracker
{
    public class MyCustomException : FormatException
    {
        public MyCustomException()
        {
            
        }

        public override string ToString()
        {
            var message = Message;
            return message;
        }
    }
}