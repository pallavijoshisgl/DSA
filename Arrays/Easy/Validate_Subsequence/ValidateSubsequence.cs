using System;
using System.Collections.Generic;


public class ValidateSubsequence
{
    public static bool IsValidSubsequence(List<int> array, List<int> sequence)
    {
        // Write your code here.
        int i = 0;
        int j = 0;
        while (i < array.Count && j < sequence.Count)
        {
            if (array[i] == sequence[j])
            {
                j++;
            }
            i++;
        }
        return j == sequence.Count;
    }

    public static void Main(string[] args)
    {
        List<int> array = new List<int>() { 5, 1, 22, 25, 6, -1, 8, 10 };
        List<int> sequence = new List<int>() { 1, 6, -1, 10 };

        Console.WriteLine(IsValidSubsequence(array, sequence));
    }
}
