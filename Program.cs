// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    public static string CaesarCypherEncryptor(string str, int key)
    {
        // Write your code here.
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        string output = "";
        // List<char> charLst=new List<char>() {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
        foreach (char ch in str)
        {
            int idx = alphabet.IndexOf(ch);
            idx = (idx + key) % 26;
            output += alphabet[idx];

        }
        return output;
    }

    public static void Main(string[] args)
    {
        string result=CaesarCypherEncryptor("xyz", 2);
        Console.WriteLine(result);
    }
}

