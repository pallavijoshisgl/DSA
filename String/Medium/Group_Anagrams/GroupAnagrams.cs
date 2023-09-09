using System;
using System.Linq;
using System.Collections.Generic;



public class GroupAnagrams
{
    public static List<List<string>> groupAnagrams(List<string> words)
    {

        Dictionary<int,List<string>> anagramsDictionary = new Dictionary<int,List<string>>();
        foreach(var word in words)
        {
            var asciSum = GetAnagramKey(word);
            if (!anagramsDictionary.ContainsKey(asciSum))
            {
                anagramsDictionary.Add(asciSum, new List<string>() { word });
            }
            else
            {
                var existingVal = anagramsDictionary[asciSum];
                existingVal.Add(word);
                anagramsDictionary[asciSum] = existingVal;
            }
        }

        var result= new List<List<string>>();
        foreach(var item in anagramsDictionary)
        {
            result.Add(item.Value);
        }
        return result;
    }
    

    public static int GetAnagramKey(string word)
    {
        var sum = 0;
        foreach(var item in word)
        {
            sum += ((int)item) * ((int)item);
        }
        return sum;
    }

    public static void Main(string[] args)
    {
        List<string> vs = new List<string>() { "yo", "act", "flop", "tac", "foo", "cat", "oy", "olfp" };

       var result= groupAnagrams(vs);
    }
    
}