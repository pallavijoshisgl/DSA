using System;
using System.Collections.Generic;


public class Program
{
    public static bool CreateDocument(string characters, string document)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>();
        foreach (var character in characters)
        {
            if (!dic.ContainsKey(character))
            {
                dic.Add(character, 0);
            }
            dic[character]++;
        }

        foreach (var ch in document)
        {
            if (!dic.ContainsKey(ch) || dic[ch] == 0)
            {
                return false;
            }
            dic[ch]--;

        }
        return true;
    }

    public static void Main(string[] args)
    {
        bool result = CreateDocument("xghjklwexvbnm", "vewxcbn");
        Console.WriteLine(result);
    }
}