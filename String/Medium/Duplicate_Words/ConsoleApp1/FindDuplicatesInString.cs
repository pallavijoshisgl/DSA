using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FindDuplicatesInString
    {
        public static string FindDuplicatesCd(string str)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            string result = string.Empty;
            for (int i = 0; i < str.Length - 1; i++)
            {
                string words = str.Substring(i, 2);

                if (!dic.ContainsKey(words))
                {
                    dic.Add(words, 1);
                }
                else
                {
                    dic[words]++;
                }


            }

            foreach (var k in dic.Keys)
            {
                if (dic[k] > 1)
                {
                    result = result + ',' + k;
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            string inputStr = "whoiswhoisoianoi";
            string result = FindDuplicatesCd(inputStr);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        
    }
}
