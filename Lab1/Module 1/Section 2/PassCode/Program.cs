using System;

namespace PassCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var code = "";
            var realCode = "secret";
            while (code != realCode)
            {
                Console.WriteLine("What is the pass code?");
                code = Console.ReadLine();
                switch (code)
                {
                    case "secret":
                        Console.WriteLine("Authenticated");
                        break;
                    default:
                        Console.WriteLine("Not Authenticated");
                        break;
                }
            }

            Console.WriteLine("Would you like to change the password? Y/N");
            var answer = Console.ReadLine();

            if (!answer.Equals("Y",StringComparison.CurrentCultureIgnoreCase)) return;
            Console.WriteLine("What is the new password?");
            realCode = Console.ReadLine();

            Console.WriteLine("Password is updated.");
        }
    }
}
