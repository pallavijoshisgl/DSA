using System;

public class BestSeat
{
    public static int Best_Seat(int[] seats)
    {
        int maxSpace = 0;
        int availableSpace = 0;
        int bestSeat = 0;
        int j = 0;
        for (int i = 0;i<seats.Length;i++)
        {
            j = i + 1;
            while (j < seats.Length && seats[j] == 0)
            {
                j++;
            }
            availableSpace = j - i - 1;
            if(availableSpace>maxSpace)
            {
                maxSpace = availableSpace;
                bestSeat = (i + j) / 2;
                j = i;
            }
            
        }
        return bestSeat;
    }

    public static void Main(string[] args)
    {
        int[] seats = new int[] { 1, 0, 1, 0, 0, 1,0,0,0,0,1 };
        Console.WriteLine(Best_Seat(seats));
    }
}
