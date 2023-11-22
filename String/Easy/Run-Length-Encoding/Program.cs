using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_Length_Encoding
{
    internal class Program
    {
        public static string RunLengthEncoding(string str)
        {
            StringBuilder sb = new StringBuilder();
            var ch= str[0];
            int count = 0;
            for(int i=0;i<str.Length;i++)
            {
               
                if(count==9 || ch != str[i])
                {
                    sb.Append(count);
                    sb.Append(ch);
                    count = 1;
                    ch= str[i];
                }
                else if(ch == str[i])
                {
                    count++;
                }
                
            }
            sb.Append(count);
            sb.Append(ch);
            return sb.ToString();

        }
        static void Main(string[] args)
        {
            string str = "AAAAAAAAAAAABBCC";
            string result=RunLengthEncoding(str);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
