// See https://aka.ms/new-console-template for more information

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        int[] arrays = new int[26];
        for(int i = 0; i < s.Length; i++)
        {
            arrays[s[i] - 'a']++;
            arrays[t[i] - 'a']--;
        }
        for(int i = 0; i < 26; i++)
        {
            if(arrays[i] != 0)
            {
                return false;
            }
        }

        return true;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        string s = "ehllo";
        string t = "hello";
        int[] sArray = new int[s.Length];
        int[] tArray = new int[t.Length];

        // Populate sArray and tArray with ASCII values of characters in s and t
        for (int i = 0; i < s.Length; i++)
        {
            sArray[i] = s[i];
            tArray[i] = t[i];
        }

        // Print the arrays
        Console.WriteLine("Array of characters in s string:");
        for (int i = 0; i < sArray.Length; i++)
        {
            Console.WriteLine(sArray[i]);
        }

        Console.WriteLine("Array of characters in t string:");
        for (int i = 0; i < tArray.Length; i++)
        {
            Console.WriteLine(tArray[i]);
        }
    }
}
