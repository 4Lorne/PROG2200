using System;

namespace Survey
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = TryAnswer();

            Console.WriteLine("What is your age?");
            var age = TryAnswer();

            Console.WriteLine("What month were you born in?");
            var month = validateMonth();

            Console.WriteLine("What day were you born?");
            var day = validateDate(month);

            var zodiac = calculateZodiac(day,month);
            
            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);
            Console.WriteLine("Your birth day is : {0}",day);

            
        }

        private static string calculateZodiac(int day, int month)
        {
            var zodiac = "";

            switch (month)
            {
                case 1: //January
                    if (day <= 19)
                    {
                        Console.WriteLine("Your sign is Capricorn.");
                    } else if (day >= 20)
                    {
                        Console.WriteLine("Your sign is Aquarius.");
                    }
                    break;
                
                case 2: //February
                    if (day <= 18)
                    {
                        Console.WriteLine("Your sign is Aquarius");
                    } else if (day >= 19)
                    {
                        Console.WriteLine("Your sign is Pisces.");
                    }
                    break;
                
                case 3: //March
                    if (day <= 19)
                    {
                        Console.WriteLine("Your sign is Pisces.");
                    } else if (day >= 21)
                    {
                        Console.WriteLine("Your sign is Aries");
                    }
                    break;
                
                case 4: //April
                    if (day <= 19)
                    {
                        Console.WriteLine("Your sign is Aries.");
                    } else if (day >= 20)
                    {
                        Console.WriteLine("Your sign is Taurus.");
                    }
                    break;
                
                case 5: //May
                    if (day <= 20)
                    {
                        Console.WriteLine("Your sign is Taurus");
                    } else if (day >= 21)
                    {
                        Console.WriteLine("Your sign is Gemini");
                    }
                    break;
                
                case 6: //June
                    if (day <= 21)
                    {
                        Console.WriteLine("Your sign is Gemini.");
                    } else if (day > 21)
                    {
                        Console.WriteLine("Your sign is Cancer.");
                    }
                    break;
                
                case 7:
                    if (day < 23)
                    {
                        Console.WriteLine("Your sign is Cancer.");
                    } else if (day >= 23)
                    {
                        Console.WriteLine("Your sign is Leo.");
                    }
                    break;
                
                case 8:
                    if (day < 23)
                    {
                        Console.WriteLine("Your sign is Leo.");
                    } else if (day >= 23)
                    {
                        Console.WriteLine("Your sign is Virgo.");
                    }
                    break;
                case 9:
                    if (day <= 23)
                    {
                        Console.WriteLine("Your sign is Virgo");
                    } else if (day >= 22)
                    {
                        Console.WriteLine("Your sign is Libra");
                    }

                    break;
                case 10:
                    if (day <= 22)
                    {
                        Console.WriteLine("Your sign is Libra");
                    } else if (day > 22)
                    {
                        Console.WriteLine("Your sign is Scorpio");
                    }

                    break;
                case 11:
                    if (day <= 21)
                    {
                        Console.WriteLine("Your sign is Scorpio");
                    } else if (day >= 22)
                    {
                        Console.WriteLine("Your sign is Sagittarius");
                    }

                    break;
                case 12:
                    if (day <= 21)
                    {
                        Console.WriteLine("Your sign is Sagittarius");
                    } else if (day >= 22)
                    {
                        Console.WriteLine("Your sign is Capricorn");
                    }

                    break;
                
            }

            return zodiac;
        }

        private static string TryAnswer()
        {
            var question = Console.ReadLine();
            if (question != "") return question;
            Console.WriteLine("You didn't type anything, please try again:");
            return Console.ReadLine();
        }

        static int validateMonth()
        {
            var validMonth = 0;
            do
            {
                var month = Console.ReadLine();
                int.TryParse(month, out validMonth);

                if (validMonth > 12 || validMonth <= 0)
                {
                    Console.WriteLine("Enter an integer between 1 and 12:");
                }
            } 
            while (validMonth > 12 || validMonth <= 0);
            

            return validMonth;
        }

        static int validateDate(int month)
        {
            var validDate = 0;
            do
            {
                var date = Console.ReadLine();
                int.TryParse(date, out validDate);

                switch (month)
                {
                    case 1:
                        validateThirtyOne(validDate);
                        break;
                    case 2:
                        if (validDate > 28 || validDate <= 0)
                        {
                            Console.WriteLine("Enter an integer between 1 and 28:");
                        }
                        break;
                    case 3:
                        validateThirtyOne(validDate);
                        break;
                    case 4:
                        validateThirty(validDate);
                        break;
                    case 5:
                        validateThirtyOne(validDate);
                        break;
                    case 6:
                        validateThirty(validDate);
                        break;
                    case 7:
                        validateThirtyOne(validDate);
                        break;
                    case 8:
                        validateThirtyOne(validDate);
                        break;
                    case 9:
                        validateThirty(validDate);
                        break;
                    case 10:
                        validateThirtyOne(validDate);
                        break;
                    case 11:
                        validateThirty(validDate);
                        break;
                    case 12:
                        validateThirtyOne(validDate);
                        break;
                }
            } while (validDate > 31 || validDate <= 0);

            return validDate;
        }

        private static void validateThirtyOne(int validDate)
        {
            if (validDate > 31 || validDate <= 0)
            {
                Console.WriteLine("Enter an integer between 1 and 31:");
            }
        }

        static void validateThirty(int validDate)
        {
            if (validDate > 30 || validDate <= 0)
            {
                Console.WriteLine("Enter an integer between 1 and 30:");
            }
        }
    }
}
