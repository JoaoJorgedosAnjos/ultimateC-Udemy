Console.WriteLine(FormatDate(2000, 12, 17));

static string FormatDate(int year, int month, int day)
{
    string date = $"{year}/{month}/{day}";
    return date;
}
/*
using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static string FormatDate(int year, int month, int day)
        {   
            string date = $"{year}/{month}/{day}";
            return date;
        }
    }
}

*/