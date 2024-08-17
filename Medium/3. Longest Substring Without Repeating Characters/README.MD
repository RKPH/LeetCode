# Longest Substring Without Repeating Characters

## Problem Description

Given a string `s`, find the length of the longest substring without repeating characters.

## Examples

### Example 1:
- **Input:** `s = "abcabcbb"`
- **Output:** `3`
- **Explanation:** The answer is `"abc"`, with the length of `3`.

### Example 2:
- **Input:** `s = "bbbbb"`
- **Output:** `1`
- **Explanation:** The answer is `"b"`, with the length of `1`.

### Example 3:
- **Input:** `s = "pwwkew"`
- **Output:** `3`
- **Explanation:** The answer is `"wke"`, with the length of `3`. Notice that the answer must be a substring, `"pwke"` is a subsequence and not a substring.

## Constraints

- `0 <= s.length <= 5 * 10^4`
- `s` consists of English letters, digits, symbols, and spaces.

## Solution Ideas

### Method 1: Using a String to Track the Substring

**Approach:**

1. **Initialization:**
    - Use a `start` pointer to track the beginning of the current substring.
    - Use a `maxLength` variable to store the length of the longest substring found.
    - Use a `result` string to build the current substring.

2. **Algorithm:**
    - Iterate over the string with the `start` pointer.
    - For each position of `start`, use a `pointer` to extend the substring while it does not contain duplicate characters.
    - If a duplicate character is found, update `maxLength` with the length of the current substring and reset `result` to start a new substring.
    - Move the `start` pointer to the next position and repeat the process.

**Time Complexity:**
- The worst-case time complexity is O(n^2) where `n` is the length of the string, because for each starting index, we potentially iterate through the remaining characters.

**Space Complexity:**
- The space complexity is O(n) for storing the substring `result`.

### Method 2: Using a List to Track the Substring

**Approach:**

1. **Initialization:**
    - Use a `list` to keep track of the current substring characters.
    - Use a `maxLength` variable to store the length of the longest substring found.
    - Use a `pointer` to track the start of the substring within the list.

2. **Algorithm:**
    - Iterate through each character of the string.
    - If the character is already in the `list`, remove characters from the list starting from the `pointer` until the character is not in the list.
    - Add the current character to the list and update `maxLength` with the size of the list if it's larger than the previous `maxLength`.
    - Move the `pointer` to keep track of the start position of the current substring.

**Time Complexity:**
- The worst-case time complexity is O(n) where `n` is the length of the string. Each character is added and removed from the list at most once.

**Space Complexity:**
- The space complexity is O(n) for storing the list of characters.

## Summary

Both methods effectively find the length of the longest substring without repeating characters, but they differ in approach and performance. The first method uses a string to track characters, while the second method uses a list to manage the substring. The second method is generally more efficient due to its linear time complexity.

## Examples in Code

- **Example 1:**
  ```csharp
  Solution sol = new Solution();
  int result = sol.LengthOfLongestSubstring("abcabcbb");
  // Output: 3 (substring is "abc")
