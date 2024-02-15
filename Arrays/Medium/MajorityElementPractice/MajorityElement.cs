using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorityElementPractice
{
    internal class MajorityElement
    {
        public static int FindMajorityElement(int[] array)
        {
            int count = 0;
            int majorityElement = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(count == 0)
                {
                    majorityElement=array[i];
                }
                if(array[i]== majorityElement)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
            return count>=1?majorityElement : -1;
        }
        static void Main(string[] args)
        {
            int[] inputArray = new int[] { 1, 2, 3, 2, 2, 1, 2 };
            int result = FindMajorityElement(inputArray);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
