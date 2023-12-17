Console.WriteLine(DescribeDay(15));

static string DescribeDay(int dayNumber)
{
    switch (dayNumber)
    {
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
            return "Working day";
            break;
        case 6:
        case 7:
            return "Weekend";
            break;
        default:
            return "Invalid day number";
            break;
    }
}
/*
using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static string DescribeDay(int dayNumber)
        {
            switch(dayNumber){
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                return "Working day";
                break;
                case 6:
                case 7:
                return "Weekend";
                break;
                default:
                return "Invalid day number";
                break;
            }
        }
    }
}
*/