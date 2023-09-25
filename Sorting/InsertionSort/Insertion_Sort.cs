using System;
using System.Collections.Generic;


public class InsertionSort
{
    public static int[] Insertion_Sort(int[] array)
    {
        return Solve(array);
    }

    public static int[] Solve(int[] array,int start=0,int ptr=1)
    {

        if(start>=array.Length-1)
        {
            return array;
        }

        if(ptr!=0 && array[ptr]<array[ptr-1])
        {
            var temp=array[ptr];
            array[ptr]=array[ptr-1];
            array[ptr-1]=temp;
        }

        return Solve(array, start, ptr - 1);
    }

    public static void Main(string[] args)
    {

    }
}