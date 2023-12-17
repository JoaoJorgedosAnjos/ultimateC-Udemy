Console.WriteLine(IsElseConditionalStatement(10));

static string IsElseConditionalStatement(int number)
{
    string result;

    if (number < 0)
    {
        result = "negative";
    }
    else if (number == 0)
    {
        result = "zero";
    }
    else
    {
        result = "positive";
    }

    return result;
}

/*
using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static string IsElseConditionalStatement()
        {
            int number = 0;
            
            string result;
            
            if(number < 0){
                result = "negative";
            }
            else if(number == 0){
                 result = "zero";
            }else{
                result = "positive";
            }
            
            return result;
        }
    }
}
*/

