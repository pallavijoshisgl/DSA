using System;


public class MajorityEelemnt
{
    public static int FindMajorityElement(int[] inputArray)
    {
        int counter = 0;
        int majorityElement = 0;
        for(int i=0; i<inputArray.Length; i++)
        {
            if(counter==0)
            {
                majorityElement=inputArray[i];
            }
           
            if(inputArray[i] == majorityElement)
            {
                counter++;
            }
            else
            {
                counter--;
            }
        }
        return majorityElement;

    }

    public static void Main(string[] args)
    {
        int[] input = new int[] { 1, 2, 3, 4, 2, 5, 2, 2 };
        int result= FindMajorityElement(input);
        Console.WriteLine(result);
    }
}
