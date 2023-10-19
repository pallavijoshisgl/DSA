using System;


public class Longest_Cons_Sub
{
    public static int Get_longest_Con_Subsequence(int[] nums)
    {
        if(nums.Length < 2)
        {
            return nums.Length;
        }

        Array.Sort(nums);

        int max_Length = 1;
        int currentLength = 1;

        for(int i=1;i<nums.Length;i++)
        {
            if(nums[i]-nums[i-1] == 1)
            {
                currentLength++;
            }
            else if(nums[i]==nums[i-1])
            {
                continue;
            }
            else
            {
                currentLength = 1;
            }

            max_Length = Math.Max(max_Length, currentLength);
        }

        return max_Length;
    }


    public static void Main(string[] args)
    {
        int[] nums = new int[] { 100, 4, 200, 1, 3, 2 };
        int result=Get_longest_Con_Subsequence(nums);
        Console.WriteLine(result);
    }

}