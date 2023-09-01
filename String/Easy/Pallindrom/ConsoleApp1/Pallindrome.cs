using System;
using System.Collections.Generic;

public class Pallindrome
{
    public static bool IsPallindrome(string str)
    {
        char[] charArr=str.ToCharArray();
        string revStr = "";
        for (int i = charArr.Length - 1; i >= 0; i--)
        {
            revStr=revStr + charArr[i];
        }
        if(str==revStr)
        {
            return true;
        }

        return false;
    }



    public static void Main(string[] args)
    {
        bool result = IsPallindrome("abcdcb");
        Console.WriteLine(result);
    }
}