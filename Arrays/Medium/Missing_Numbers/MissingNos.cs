using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missing_Numbers
{
    public class MissingNos
    {

        public static int[] MissingNumbers(int[] nums)
        {
            var result = new List<int>();
            var expectedTotal = nums.Length + 2;

            for(int i=1;i<=expectedTotal;i++)
            {
                if (nums.Contains(i)) continue;
                else
                {
                    result.Add(i);
                }
            }

            return result.ToArray();
        }
        static void Main(string[] args)
        {

            int[] nums = new int[] { 1, 3, 4, 5 };
            int[] result= MissingNumbers(nums);

            for(int i=0;i<result.Length;i++)
            {
                Console.WriteLine(result[i]);
            }

            Console.ReadKey();
        }
    }
}
