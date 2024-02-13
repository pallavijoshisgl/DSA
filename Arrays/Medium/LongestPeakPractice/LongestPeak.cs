using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPeakPractice
{
    internal class LongestPeak
    {
        public static int LongestPeakCode(int[] array)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            int maxLongestPeak = 0;
            for(int i=1;i<array.Length-1;i++)
            {
                if(array[i]>array[i-1] && array[i]>array[i+1])
                {
                    leftIndex = i - 2;
                    while(leftIndex>=0 && array[leftIndex]<array[leftIndex+1])
                    {
                        leftIndex--;
                    }
                    rightIndex = i + 2;
                    while(rightIndex<array.Length && array[rightIndex]<array[rightIndex-1])
                    {
                        rightIndex++;
                    }
                    int currentLongestPeak = rightIndex - leftIndex - 1;
                    maxLongestPeak = Math.Max(maxLongestPeak, currentLongestPeak);
                }
            }
            return maxLongestPeak;
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 3, 4, 0, 10, 6, 5, -1, -3, 2, 3 };
            int result= LongestPeakCode(array);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
