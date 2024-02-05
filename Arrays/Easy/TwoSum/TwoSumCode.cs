using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    internal class TwoSumCode
    {

        public static int[] TwoSum(int[] nums,int target)
        {
            Dictionary<int,int> dic=new Dictionary<int,int>();
            for(int i=0;i<nums.Length;i++)
            {
                if(dic.ContainsKey(target-nums[i]))
                {
                    return new int[] { dic[target-nums[i]], i };
                }

                if(!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], i);
                }
            }
            return null;

        }
        static void Main(string[] args)
        {
            int[] input = new int[] { 2, 7, 11, 15 };
            int target = 9;

            int[] result=TwoSum(input, target);

            for(int i=0;i<result.Length;i++)
            {
                Console.WriteLine(result[i]);
                
            }

            Console.ReadKey();
        }
    }
}
