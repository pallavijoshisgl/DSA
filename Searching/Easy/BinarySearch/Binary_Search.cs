using System;


public class Binary_Search
{
    public static int BinarySearch(int[] array, int target)
    {
        int l = 0;
        int h = array.Length - 1;

        while(l<=h)
        {
            int mid = l + (h - l) / 2;
            if(array[mid]==target)
            {
                return mid;
            }
            else if(array[mid]>target)
            {
                h = mid - 1;
            }
            else if(array[mid]<target)
            {
                l = mid + 1;
            }
        }
        return -1;
    }

    public static void Main(string[] args)
    {
        int[] array = new int[] { 1, 5, 7, 9, 10, 22, 33, 44 };
        int target = 44;
        Console.WriteLine(BinarySearch(array, target));
    }
}
