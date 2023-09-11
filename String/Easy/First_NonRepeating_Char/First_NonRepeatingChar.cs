using System;

public class First_NonRepeatingChar
{
    public static int FirstNonRepeatingCharacter(string str)
    {
        int Length = str.Length;

        for(int i=0; i<Length; i++)
        {
            char ch = str[i];
            string sub = str.Remove(i, 1);
            if(!sub.Contains(ch))
            {
                return i;
            }

        }
        return -1;
    }

    public static void Main(string[] args)
    {
        string str = "abcdcaf";
        Console.WriteLine(FirstNonRepeatingCharacter(str));

    }
}
