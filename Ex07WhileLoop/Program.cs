Console.WriteLine(CalculateSumOfNumbersBetween(15,15));

static int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber)
{
    int sum = 0;
    while (firstNumber <= lastNumber)
    {
        sum += firstNumber;
        firstNumber++;
    }
    return sum;
}

/*
using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber)
        {
            //your code goes here
            int sum = 0;
            while (firstNumber <= lastNumber)
            {   
            sum += firstNumber;
            firstNumber++;
            }
               return sum;
        }
    }
}
*/