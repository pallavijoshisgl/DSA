using System;
using System.Collections.Generic;


public class ThreeNumSum_Practice
{
    public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
    {
        int leftPointer, rightPointer, numbertoFind;
        List<int[]> result = new List<int[]>();
        Array.Sort(array);
        for(int i=0; i<array.Length; i++)
        {
            leftPointer = i + 1;
            rightPointer = array.Length - 1;
             numbertoFind = targetSum - array[i];
            while(leftPointer < rightPointer)
            {
                int sum = array[leftPointer] + array[rightPointer];
                if(sum == numbertoFind)
                {
                    result.Add(new int[] { array[i],array[leftPointer], array[rightPointer] });
                    leftPointer++;
                    rightPointer--;
                }
                if(numbertoFind > sum)
                {
                    leftPointer++;
                }
                if(numbertoFind < sum)
                {
                    rightPointer--;
                }
            }
        }
        return result;
    }

    public static void Main(string[] args)
    {
        int[] array = { 12, 3, 1, 2, -6, 5, -8, 6 };
        int targetSum = 0;
        var result=ThreeNumberSum(array, targetSum);
        foreach(int[] array2 in result)
        {
            foreach(var x in array2)
            {
                Console.WriteLine(x);
            }
        }
        Console.ReadKey();
    }
}
