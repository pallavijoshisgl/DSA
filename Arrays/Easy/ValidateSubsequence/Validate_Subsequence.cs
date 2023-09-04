using System;

public class Validate_Subsequence
{
    public static bool IsValidSubsequence(List<int> array,List<int> sequence)
    {
        int i = 0;
        int j = 0;
        while(i< array.Count && j < sequence.Count)
        {
            if(array[i] == sequence[j])
            {
                j++;
            }
            i++;
        }
        return j==sequence.Count;
    }

    public static void Main(string[] args)
    {
        List<int> arr = new List<int>() { 5, 1, 22, 25, 6, -1, 8, 10 };
        List<int> sq = new List<int>() { 1, 6, -1, 10 };
        Console.WriteLine(IsValidSubsequence(arr, sq));

    }
}