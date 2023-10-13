using System;
using System.Collections.Generic;

public class LongestPeak
{
    public static int GetLongestPeakfromArray(int[] array)
    {
        int i = 1;
        int LongestPeak = 0;
        int leftIdx = 0;
        int rightIdx = 0;
        int CurrentPeak = 0;

        while(i < array.Length - 1)
        {
            bool isPeak = array[i] > array[i - 1] && array[i] > array[i + 1];
            if (!isPeak)
            {
                i += 1;
                continue;
            }
            leftIdx = i - 2;
            while(leftIdx>=0 && array[leftIdx] < array[leftIdx + 1])
            {
                leftIdx -= 1;
            }
            rightIdx = i + 2;
            while(rightIdx<array.Length && array[rightIdx] < array[rightIdx - 1])
            {
                rightIdx += 1;
            }
            CurrentPeak = rightIdx - leftIdx - 1;
            LongestPeak = Math.Max(CurrentPeak, LongestPeak);
            i = rightIdx;

                 

        }
        return LongestPeak;
    }

    public static void Main(string[] args)
    {
        int[] arr = new int[] { 1, 2, 3, 3, 4, 0, 10, 6, 5, -1, -3, 2, 3 };
        Console.WriteLine(GetLongestPeakfromArray(arr));
    }
}
