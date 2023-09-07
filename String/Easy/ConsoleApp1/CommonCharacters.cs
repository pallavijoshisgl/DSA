using System;
using System.Collections.Generic;
using System.Linq;

public class CommonCharacters
{
    public static string[] FindCommonCharacters(string[] strings)
    {
        var sharedChars = new HashSet<char>();
        for(int i=0; i<strings[0].Length; i++)
        {
            sharedChars.Add(strings[0][i]);
        }

        var sharedCharCopy = sharedChars.ToList();
        for(int i=0;i<strings.Length; i++)
        {
            if(sharedCharCopy.Count==0)
            {
                return new string[0];
            }
            foreach(char letter in sharedCharCopy)
            {
                if(!strings[i].Contains(letter))
                {
                    sharedChars.Remove(letter);
                }
            }
        }
        return sharedChars.ToArray().Select(c => c.ToString()).ToArray();
    }

    public static void Main(string[] args)
    {
        
    }
}