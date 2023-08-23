using System.Collections.Generic;
using System;

public class First_Duplicate_Value
{
    public static int FirstDuplicateValue(int[] array)
    {
        // Write your code here.
        for (int i = 0; i < array.Length; i++)
        {
            int absValue = Math.Abs(array[i]);
            int index = absValue - 1;
            if (array[index] < 0) return absValue;
            array[index] = array[index] * -1;
        }

        return -1;
    }

    public static void Main(string[] args)
    {
        int[] inputArray = { 2, 3, 4, 5, 4, 9, 8, 6 };
        Console.WriteLine(FirstDuplicateValue(inputArray));
    }
}

