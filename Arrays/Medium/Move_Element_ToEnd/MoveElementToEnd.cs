using System;
using System.Collections.Generic;

public class MoveElementToEnd
{
    public static List<int> Move_ElementToEnd(List<int> array,int toMove)
    {
        int leftpointer = 0;
        int rightpointer = array.Count - 1;
        while(leftpointer < rightpointer)
        {
            if(array[leftpointer] == toMove && array[rightpointer]!=toMove)
            {
                int temp=array[leftpointer];
                array[leftpointer]=array[rightpointer];
                array[rightpointer]=temp;

                leftpointer++;
                rightpointer--;

            }
            if(array[rightpointer] == toMove )
            {
                rightpointer--;

            }
            if(array[leftpointer] != toMove )
            {
                leftpointer++;
            }
        }
        return array;
    }

    public static void Main(string[] args)
    {
        List<int> array = new List<int>() { 2, 1, 2, 2, 2, 3, 4, 2 };

        int toMove = 2;

        List<int> result=Move_ElementToEnd(array,toMove);

        foreach(var item in result)
        {
            Console.WriteLine(item);
        }

    }


}