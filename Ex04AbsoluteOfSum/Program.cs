Console.WriteLine(AbsoluteOfSum(10, 15));

static int AbsoluteOfSum(int number1, int number2)
{
    int sum = number1 + number2;
    if (sum < 0)
    {
        sum *= -1;
        return sum;
    }
    return sum;
}


/*using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static int AbsoluteOfSum(int a, int b)
        {   
           int sum = a + b;
    if (sum < 0)
    {
        sum *= -1;
        return sum;
    }
    return sum;
        }
    }
}
*/