using System;



public class Run_Length_Encoding
{
    public static string RunLengthEncoding(string s)
    {
        int currentLength = 1;
        string result = "";

        for(int i=1;i<s.Length;i++)
        {
            char currentCharacter = s[i];
            char previousCharacter = s[i - 1];

            if(currentCharacter!=previousCharacter || currentLength==9)
            {
                result+=currentLength.ToString();
                result += previousCharacter.ToString();
                currentLength = 0;
            }

            currentLength += 1;
        }

        result += currentLength.ToString();
        result += s[s.Length - 1].ToString();

        return result;

    }


    public static void Main(string[] args)
    {
        Console.WriteLine(RunLengthEncoding("AAAAAAAAAAAAAABBBCCDD"));
    }
}
