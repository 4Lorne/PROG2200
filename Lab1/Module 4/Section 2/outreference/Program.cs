using System;

namespace outreference
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 2;

            Console.WriteLine(x);

            Five(out x);

            Console.WriteLine(x);

            var test = "1.5";
            var outDouble = 0.0;
            Console.WriteLine("Result: {0}", parseDouble(test, out outDouble));
            Console.WriteLine("Test type is {0}", outDouble.GetType());
            test = "Ronan";
            outDouble = 0.0;
            Console.WriteLine("Result: {0}", parseDouble(test, out outDouble));
            Console.WriteLine("Test value is {0}", outDouble);

            
            
        }

        static void Five(out int a)
        {
            a = 5;
            Console.WriteLine(a);
        }

        static bool parseDouble(string input, out double output)
        {
            var outputBool = double.TryParse(input, out output);
            return outputBool;
        }
    }
}
