int[,] array1 = new int[0, 3];
Console.WriteLine(FindMax(array1));

int[,] array2 = { { 1, 5, 12, 3, -1, 4 } };
Console.WriteLine(FindMax(array2));

static int FindMax(int[,] numbers)
{
    var height = numbers.GetLength(0);
    int width = numbers.GetLength(1);
    int temp = -100;
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            if (temp <= numbers[i, j])
            {
                temp = numbers[i, j];
            }
        }
    }
    if (height == 0 || width == 0)
    {
        return -1;
    }
    else
    {
        return temp;
    }
}
/*using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static int FindMax(int[,] numbers)
        {
            var height = numbers.GetLength(0);
            int width = numbers.GetLength(1);
            int temp = -100;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (temp <= numbers[i, j])
                    {
                        temp = numbers[i, j];
                    }
                }
            }
            if (height == 0 || width == 0)
            {
                return -1;
            }
            else
            {
                return temp;
            }
        }
    }
}
*/