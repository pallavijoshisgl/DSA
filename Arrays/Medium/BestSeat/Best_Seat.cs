using System;

public class Best_Seat
{
    public int FindBestSeat(int[] seats)
    {

        int maxSpace = 0;
        int availableSpace = 0;
        int BestSeat = -1;
        int j = 0;
        for(int i=0; i<seats.Length; i++)
        {
            j = i + 1;
            while(j< seats.Length && seats[j]==0)
            {
                j++;
            }
            availableSpace = j - i - 1;
            if(availableSpace > maxSpace)
            {
                maxSpace = availableSpace;
                BestSeat = (j + i) / 2;
                j = i;
            }
        }
        return BestSeat;
    }

    public static void Main(string[] args)
    {

    }
}