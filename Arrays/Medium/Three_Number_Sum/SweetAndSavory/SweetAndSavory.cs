using System;

public class SweetAndSavory
{
    public static int[] SweetAndSavoryPrg(int[] dishes, int target)
    {
        // Write your code here.
        int mindiff = Int32.MaxValue;
        Array.Sort(dishes);
        int savoryIdx = 0;
        int[] result = new int[] { 0, 0 };
        while (savoryIdx < dishes.Length && dishes[savoryIdx] < 0) savoryIdx++;
        for (int i = 0; i < savoryIdx; i++)
        {
            for (int j = savoryIdx; j < dishes.Length; j++)
            {
                int profile = dishes[i] + dishes[j];
                if (profile <= target)
                {
                    var diff = target - profile;
                    if (diff < mindiff)
                    {
                        mindiff = diff;
                        result = new int[] { dishes[i], dishes[j] };
                    }
                }
            }
        }
        return result;
    }


    public static void Main(string[] args)
    {
        int[] dishes = { -3, -5, 3, 4 };
        Console.WriteLine(SweetAndSavoryPrg(dishes,8));
    }
}

