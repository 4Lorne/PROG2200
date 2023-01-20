using System;

namespace Survey
{
    class Data
    {
        public string Name;
        public int Age;
        public string Month;
        public int MonthNum;

        public enum MonthEnum
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        
        public void Display()
        {
            MonthEnum monthEnum = MonthEnum.April;
            Console.WriteLine("Your name is: {0}", Name);
            Console.WriteLine("Your age is: {0}", Age);
            Console.WriteLine("Your birth month is: {0}", Month);
            switch (MonthNum)
            {
                case (int) MonthEnum.January:
                    Console.WriteLine("You are a Capricorn.");
                    break;
                case (int) MonthEnum.February:
                    Console.WriteLine("You are an Aquarius.");
                    break;
                case (int) MonthEnum.March:
                    Console.WriteLine("You are a Pisces.");
                    break;
            }
            

            /*if (Month.March)
            {
                Console.WriteLine("you are an Aries.");
            }
            else if (Month == "april")
            {
                Console.WriteLine("you are a Taurus.");
            }
            else if (Month == "may")
            {
                Console.WriteLine("you are a Gemini.");
            }*/
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Data();

            Console.WriteLine("What is your name?");
            data.Name = TryAnswer();

            Console.WriteLine("What is your age?");
            data.Age = int.Parse(TryAnswer());

            Console.WriteLine("What month were you born in?");
            data.Month = TryAnswer();

            data.MonthNum = determineMonth(data.Month, data.MonthNum);
            
            data.Display();
        }

        static int determineMonth(string month, int monthNum)
        {
            switch (month)
            {
                case "January":
                    monthNum = 1;
                    break;
                case "February":
                    monthNum = 2;
                    break;
                case "March":
                    monthNum = 3;
                    break;
            }
            return monthNum;
        }

        static string TryAnswer()
        {
            var question = Console.ReadLine();
            if (question == "")
            {
                Console.WriteLine("You didn't type anything, please try again:");
                return Console.ReadLine();
            }
            return question;
        }
    }
}
