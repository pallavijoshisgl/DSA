using System;
using System.Collections.Generic;   

public class Two_Number_Sum
{
    public static int[] TwoNumberSum(int[] array,int targetSum)
    {
        Array.Sort(array);
        int i = 0;
        int j = array.Length - 1;

        while(i<=j)
        {
            if(array[i] + array[j] == targetSum)
            {
                return new int[] { array[i], array[j] };
            }
            else if(array[i] + array[j]< targetSum)
            {
                i++;
            }
            else
            {
                j--;
            }
        }
        return new int[0];
    }


    public static void Main(string[] args)
    {
        int[] inputArray = new int[] { 3, 5, -4, 8, 11, 1, -1, 6 };
        int targetSum = 10;
        Console.WriteLine(TwoNumberSum(inputArray, targetSum));
    }
}