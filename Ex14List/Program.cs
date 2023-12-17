var words = new List<string>()
{"one",
"TWO123",
"THREE!&^",
"four",
"TWO"};

List<string> words2 = new List<string>()
{"one",
"TWO123",
"THREE!&^",
"four",
"TWO",
"THREE"};

foreach (var word in GetOnlyUpperCaseWords(words))
{
 Console.WriteLine(word);   
}

foreach (var word in GetOnlyUpperCaseWords(words2))
{
 Console.WriteLine(word);   
}

List<string> GetOnlyUpperCaseWords(List<string> words)
{
    List<string> result = new List<string>();
    foreach (var word in words)
    {
        foreach (char character in word)
        {
            bool isUpperCase = char.IsUpper(character);
            if (word.All(char.IsUpper) && !result.Contains(word))
            {
                result.Add(word);
            }
        }
    }
    return result;
}

/*
using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public List<string> GetOnlyUpperCaseWords(List<string> words)
        {
            List<string> result = new List<string>();
            foreach (var word in words)
            {
                foreach (char character in word)
                {
                    bool isUpperCase = char.IsUpper(character);
                    if (word.All(char.IsUpper) && !result.Contains(word))
                    {
                        result.Add(word);
                    }
                }
            }
            return result;

        }
    }
}
*/