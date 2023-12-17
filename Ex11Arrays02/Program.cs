Console.WriteLine(IsWordPresentInCollection(["one","two"],"two"));

static bool IsWordPresentInCollection(string[] words, string wordToBeChecked)
{

    bool wordChecked = false;

    for (int i = 0; i < words.Length; i++)
    {
        if (wordToBeChecked == words[i])
        {
            wordChecked = true;
        }
    }

    return wordChecked;
}
/*using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static bool IsWordPresentInCollection(string[] words, string wordToBeChecked)
        {

            bool wordChecked = false;

            for (int i = 0; i < words.Length; i++)
            {
                if (wordToBeChecked == words[i])
                {
                    wordChecked = true;
                }
            }

            return wordChecked;
        }
    }
}
*/
