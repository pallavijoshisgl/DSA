using System;
using System.Collections.Generic;


public class Sweet_And_Savory
{
    public int[] SweetAndSavory(int[] dishes,int target)
    {
        int mindiff = Int32.MaxValue;
        Array.Sort(dishes);
        int savoryIdx = 0;
        int[] result=new int[] {0,0 };
        while (savoryIdx < dishes.Length && dishes[savoryIdx] < 0) savoryIdx++;
        for (int i = 0; i < savoryIdx; i++)
        {
            for(int j=savoryIdx; j < dishes.Length;j++)
            {
                int profile = dishes[i] + dishes[j];
                if(profile<=target)
                {
                    var diff=target - profile;
                    if(diff < mindiff)
                    {
                        mindiff = diff;
                        result = new int[] { dishes[i], dishes[j] };
                    }
                }
            }
        }
    }

    public static void Main(string[] args)
    {

    }
}