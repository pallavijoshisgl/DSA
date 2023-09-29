using System;
using System.Collections.Generic;


public class ThreeLargestNumbersFromArray
{
    public static int[] GetThreeLargestNos(int[] array)
    {
        
        int n1 = int.MinValue;
        int n2 = int.MinValue;
        int n3 = int.MinValue;

        
        foreach (var x in array)
        {
            if(x>n1 || n1==int.MinValue)
            {
                n3 = n2;
                n2 = n1;
                n1 = x;
            }
            else if(x>n2 || n2==int.MinValue)
            {
                n3 = n2;
                n2 = x;


            }
            else if(x>n3)
            {
                n3 = x;
            }
        }
        return new int[] { n1, n2, n3 };
    }

    public static void Main(string[] args)
    {
        int[] array = new int[] { 34, 45, 56, 78, 12, 5, 89, 90 };
        int[] result = new int[3];
        result=GetThreeLargestNos(array);
        for(int i=0;i<result.Length;i++)
        {
            Console.Write(result[i] + ",");
        }
    }
}
