using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidAnagram
{
    internal class ValidAnagramProgram
    {
        static Dictionary<char, int> dic = new Dictionary<char, int>();
        public static bool IsAnagram(string s, string t)
        {
            for(int i=0;i<s.Length;i++)
            {
                if(!dic.ContainsKey(s[i]))
                {
                    dic.Add(s[i], 1);
                }
                else
                {
                    dic[s[i]] += 1;
                }
            }

            for(int j=0;j< t.Length;j++)
            {
                if(!dic.ContainsKey(t[j]))
                {
                    return false;
                }
                else
                {
                    dic[t[j]] -= 1;
                }
            }

            if(dic.Values.All(v=>v==0))
            {
                return true;
            }
           
            return false;
            

        }
        static void Main(string[] args)
        {
            string s = "anagram";
            string t = "nagaram";

            Console.WriteLine(IsAnagram(s, t));
            Console.ReadLine();
        }
    }
}
