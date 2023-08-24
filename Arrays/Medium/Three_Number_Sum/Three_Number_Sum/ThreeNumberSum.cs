using System;
using System.Collections.Generic;

public class Program
{
    public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
    {
        Array.Sort(array);
        int j, k;
        List<int[]> result = new List<int[]>();
        
        for(int i=0; i<array.Length; i++)
        {
            j = i + 1;
            k = array.Length - 1;
            while(j<k)
            {
                if(array[i] + array[j]==targetSum - array[k])
                {

                    result.Add(new int[] { array[i], array[j], array[k] });
                    j++;
                    k--;

                }
                if(array[i] + array[j] + array[k] < targetSum)
                {
                    j++;
                }
                if(array[i] + array[j] + array[k] > targetSum )
                {
                    k--;
                }
            }
        }
        return result;
    }

    public static void Main(string[] args)
    {
        int[] inputArray = new int[8] { 12, 3, 1, 2, -6, 5, -8, 6 };
        int targetSum = 0;
        List<int[]> output=ThreeNumberSum(inputArray, targetSum);
        foreach(var x in output)
        {
            Console.WriteLine(x.ToArray());
        }

    }
}