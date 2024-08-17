namespace DefaultNamespace;

public class Solution
{
    // Method 1: Using a String to Track the Substring
    public int LengthOfLongestSubstring(string s) {
        //example: s ="pwwkew"
        int start = 0; // Start pointer for the current substring
        int maxLength = 0; // Variable to store the maximum length of substring found
        string result = ""; // String to store the current substring

        // Outer loop to iterate through the string
        while (start < s.Length) {
            int pointer = start; // Pointer to traverse the string from the current start position

            // Inner loop to add characters to the result string until a duplicate character is found
            while (pointer < s.Length && !result.Contains(s[pointer])) {
                result += s[pointer]; // Add character to result
                pointer++; // Move pointer to the next character
            }

            // Update maxLength if the current result length is greater than maxLength
            maxLength = Math.Max(maxLength, result.Length);

            // Reset the result string to start a new substring
            result = "";

            // Move the start pointer to the next character in the string
            start++;
        }

        // Return the maximum length of substring found
        return maxLength;
    }

    // Method 2: Using a List to Track the Substring
    public int LengthOfLongestSubstring(string s)
    {
        List<char> list = new List<char>(); // List to store the current substring characters
        int maxLength = 0; // Variable to store the maximum length of substring found
        int pointer = 0; // Pointer to keep track of the start of the substring in the list

        // Example: s = "pwwkew"

        // Loop to iterate through the string
        for(int i = 0; i < s.Length; i++) {

            // Inner loop to remove characters from the list until the current character is not a duplicate
            while (list.Contains(s[i])) {
                list.Remove(s[pointer]); // Remove the character at the pointer position
                pointer++; // Move the pointer to the next position
            }

            // Add the current character to the list
            list.Add(s[i]);

            // Update maxLength if the current list count is greater than maxLength
            maxLength = Math.Max(maxLength, list.Count);

            // Example Step-by-Step: with s = "pwwkew"
            // i = 0, s[i] = 'p', list = [p], maxLength = 1
            // i = 1, s[i] = 'w', list = [p, w], maxLength = 2
            // i = 2, s[i] = 'w', list contains 'w', so remove 'p' (pointer=0) and 'w'(pointer=1) from the list until 'w' is not in the list
            // After removals, list = [], then add the new 'w'=>list = [w]
            // i = 3, s[i] = 'k', list = [w, k], maxLength = 2
            // i = 4, s[i] = 'e', list = [w, k, e], maxLength = 3
            // i = 5, s[i] = 'w', list contains 'w', so remove 'w'(pointer=2)  from the list [K, E]
            // After removals, list = [k, e], then add the new 'w'=>list = [k, e, w] , maxLength = 3
            // The loop ends and maxLength = 3 (for "wke")
        }

        // Return the maximum length of substring found
        return maxLength;
    }
}
