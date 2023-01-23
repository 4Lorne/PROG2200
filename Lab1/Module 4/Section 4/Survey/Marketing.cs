using System;

namespace Survey
{
    public class Marketing
    {

        public void Start()
        {
            Program.Posted += surveyPosted;
        }

        void surveyPosted()
        {
            Console.WriteLine("Thank you for completing the survey. You are now subscribed to ten of our newsletters.");
        }
    }
}