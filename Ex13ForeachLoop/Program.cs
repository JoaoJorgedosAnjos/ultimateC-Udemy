Console.WriteLine(IsAnyWordLongerThan(5,["aaa","bbbb","ccccc"]));

string[] array1 = new string[] {"aaa", "bbbb","ccccc"};
var array2 = new string[] {"aaa", "bbbb","ccccc"};

Console.WriteLine(IsAnyWordLongerThan(3,array1));
Console.WriteLine(IsAnyWordLongerThan(4,array2));

static bool IsAnyWordLongerThan(int length, string[] words)
{


    foreach (var word in words)
    {
        if (length < word.Length && word.Length != null)
        {
            return true;
        }
    }
    return false;
}

/*
using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static bool IsAnyWordLongerThan(int length, string[] words)
        {


            foreach (var word in words)
            {
                if (length < word.Length && word.Length != null)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
*/