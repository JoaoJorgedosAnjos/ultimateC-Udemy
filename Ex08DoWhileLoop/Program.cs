Console.WriteLine(RepeatCharacter('a',10));

static string RepeatCharacter(char character, int targetLength)
{
    int count = 1;
    string temp = "";
    do
    {
        temp += character.ToString();
        count++;

    } while (count <= targetLength);

    return temp;
}

/*using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static string RepeatCharacter(char character, int targetLength)
        {
            //your code goes here

            int count = 1;
            string x = "";
            do
            {
                x += character.ToString();
                count++;

            } while (count <= targetLength);

            return x;
        }
    }
}
*/