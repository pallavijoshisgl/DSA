using System;


public class Bubble_Sort
{
    public static int[] BubbleSort(int[] array)
    {
        bool isSwaped = false;
        for(int i=0;i<array.Length;i++)
        {
            for(int j=0;j<array.Length-1-i;j++)
            {
                if(array[j]>array[j+1])
                {
                    int temp=array[j];
                    array[j]=array[j+1];
                    array[j+1]=temp;

                    isSwaped=true;
                }
            }
            if(!isSwaped)
            {
                break;
            }
        }
        return array;
    }

    public static void Main(string[] args)
    {
        int[] array = new int[] { 8, 5, 2, 9, 5, 6, 3 };
        int[] output=BubbleSort(array);
        for(int k=0;k<output.Length;k++)
        {
            Console.WriteLine(output[k]);
        }

    }
}