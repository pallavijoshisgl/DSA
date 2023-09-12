using System;
using System.Collections.Generic;


public class SpiralTraverse
{
    public static List<int> GetSpiralTraverse(int[,] array)
    {
        if (array.GetLength(0) == 0) return new List<int>();

        var result = new List<int>();
        int startRow = 0;
        int startCol = 0;
        int endRow = array.GetLength(0)-1;
        int endCol = array.GetLength(1) - 1;

        while(startRow<=endRow && startCol<=endCol)
        {
            for(int col=startCol;col<=endCol; col++)
            {
                result.Add(array[startRow,col]);
            }

            for(int row=startRow + 1;row<=endRow; row++)
            {
                result.Add(array[row,endCol]);
            }

            for(int col=endCol-1;col>=startCol; col--)
            {
                if (startRow == endRow) break;
                result.Add(array[endRow,col]);
            }
            for(int row=endRow-1;row>startRow; row--)
            {
                if(startCol ==  endCol) break;
                result.Add(array[row, startCol]);

            }
            startRow++;
            endRow--;
            startCol++;
            endCol--;
        }
        return result;
    }

    public static void Main(string[] args)
    {
        int[,] input = {
      { 1, 2, 3, 4 },
      { 12, 13, 14, 5 },
      { 11, 16, 15, 6 },
      { 10, 9, 8, 7 },
    };
       List<int> output= GetSpiralTraverse(input);
       for(int i=0;i<output.Count;i++)
        {
            Console.WriteLine(output[i]);
        }

    }
}