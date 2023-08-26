using System;
using System.Collections.Generic;
public class Zero_Sum_SubArray
{
    public static bool ZeroSumSubarray(int[] nums)
    {
        // Write your code here.
        List<int> sums = new List<int>();
        int currentSum = 0;

        foreach (var x in nums)
        {
            currentSum = currentSum + x;
            if (sums.Contains(currentSum) || currentSum == 0)
            {
                return true;
            }
            else
            {
                sums.Add(currentSum);
            }
        }
        return false;

    }

    public static void Main(string[] args)
    {
        int[] nums = new int[7] { 4, -3, 2, 4, -1, -5, 7 };
        Console.WriteLine(ZeroSumSubarray(nums));
    }


}
