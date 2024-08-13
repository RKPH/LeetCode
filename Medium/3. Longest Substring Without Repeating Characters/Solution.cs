namespace DefaultNamespace;

public class Solution
{
    public int LengthOfLongestSubstring(string s) { //method 1
        int start = 0;
        int maxLength = 0;
        string result = "";

        while (start < s.Length) {
            int pointer = start;
            while (pointer < s.Length && !result.Contains(s[pointer])) {
                result += s[pointer];
                pointer++;
            }
            maxLength = Math.Max(maxLength, result.Length);
            result = "";
            start++;
        }

        return maxLength;
    }
}