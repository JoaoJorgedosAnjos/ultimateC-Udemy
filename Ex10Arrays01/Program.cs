﻿Console.WriteLine(BuildHelloString());
static string BuildHelloString()
{
    char[] letters = new char[] { 'h', 'e', 'l', 'l', 'o' };
    var result = "";
    for (int i = 0; i < letters.Length; ++i)
    {
        result += letters[i];
    }

    return result;
}

/*using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static string BuildHelloString()
        {
            char[] letters = new char[] { 'h', 'e', 'l', 'l', 'o' };
            var result = "";
            for (int i = 0; i < letters.Length; ++i)
            {
                result += letters[i];
            }

            return result;
        }
    }
}
*/