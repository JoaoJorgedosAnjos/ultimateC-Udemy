Console.WriteLine(Factorial(5));

static int Factorial(int number)
{
    int n = 1;
    for (int i = 1; i <= number; i++)
    {
        n *= i;
    }
    return n;
}

/*using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static int Factorial(int number)
        {
            int n = 1;
            for (int i = 1; i <= number; i++)
            {
                n *= i;

            }
            return n;
        }
    }
}
*/