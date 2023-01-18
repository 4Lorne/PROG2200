using System;

namespace LoopCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 5; x++)
            {
                for (int i = 1; i <= 20; i++)
                {
                    if (i >= 10)
                    {
                        int result = (2 * 10) - i;
                        if (result == 0)
                        {
                            break;
                        }
                        Console.WriteLine(result);
                    }
                    if (i <= 10)
                    {
                        Console.WriteLine(i);
                    }
                    
                }
            }
        }
    }
}
