using System;
using System.Collections.Generic;


public class MonotonicArray
{
    public static bool isNonIncreasing = true;
    public static bool isNonDecreasing = true;

    public static bool IsMonotonic(int[] inputArray)
    {
        for(int i=1; i<inputArray.Length; i++)
        {
            if(inputArray[i] < inputArray[i-1])
            {
                isNonDecreasing = false;

            }
            if(inputArray[i] > inputArray[i-1])
            {
                isNonIncreasing = false;
            }
        }

        return isNonIncreasing || isNonDecreasing;
    }

    public static void Main(string[] args)
    {
        int[] inputArray = new int[] { -1, -5, -10, -1100, -1100, -1101, -1102, -9001 };
        Console.WriteLine(IsMonotonic(inputArray));
    }
}