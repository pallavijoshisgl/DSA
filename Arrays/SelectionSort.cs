using System;

public class Program
{
    public static int[] SelectionSort(int[] array)
    {
        // Write your code here.
        int currentIdx = 0;
        int smallestIdx = 0;
        while (currentIdx < array.Length - 1)
        {
            smallestIdx = currentIdx;
            for (int j = currentIdx + 1; j < array.Length; j++)
            {
                if (array[smallestIdx] > array[j])
                {
                    int temp = array[smallestIdx];
                    array[smallestIdx] = array[j];
                    array[j] = temp;
                }
            }
            currentIdx += 1;

        }
        return array;
    }

    public static void Main(string[] args)
    {
       int[] result=SelectionSort(new[] { 2, 3, 5, 7, 9, 0 });
        Console.WriteLine(result);
    }
}


