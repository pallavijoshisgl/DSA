using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Words_In_String
{
    internal class Reverse_Words
    {
        public static string Reverse_Words_In_input(string inputStr)
        {
            string reverseWords = "";
            string word = "";

            for(int i=0;i<inputStr.Length;i++)
            {
                if(inputStr[i] == ' ')
                {
                    word = inputStr[i] + word;
                    reverseWords = word + reverseWords;
                    word = "";
                }
                else
                {
                    word=word + inputStr[i];
                }
            }
            reverseWords = word + reverseWords;
            return reverseWords;

        }
        static void Main(string[] args)
        {
            string inputStr = "Tim is great!";
            string result= Reverse_Words_In_input(inputStr);
            Console.WriteLine(result);
            Console.ReadKey();
                
        }
    }
}
