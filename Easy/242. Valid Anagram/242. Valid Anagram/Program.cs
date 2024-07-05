// See https://aka.ms/new-console-template for more information

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var charArrayS = s.ToCharArray();
        var charArrayT = t.ToCharArray();
        Array.Sort(charArrayS);
        Array.Sort(charArrayT);
        for (int i = 0; i < charArrayS.Length; i++)
        {
            if (charArrayS[i] != charArrayT[i])
            {
                return false;
            }
        }

        return true;
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            string s = "ehllo";
            string t = "hello";
            Solution solution = new Solution();
            
            Console.WriteLine(solution.IsAnagram(s, t));
        }
    }
}