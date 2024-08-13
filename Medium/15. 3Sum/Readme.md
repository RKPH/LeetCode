#Three Sum Problem

## Problem Statement

Given an integer array `nums`, return all the triplets `[nums[i], nums[j], nums[k]]` such that `i != j`, `i != k`, and `j != k`, and `nums[i] + nums[j] + nums[k] == 0`.

**Notice** that the solution set must not contain duplicate triplets.

## Examples

### Example 1

- **Input:** `nums = [-1, 0, 1, 2, -1, -4]`
- **Output:** `[[-1, -1, 2], [-1, 0, 1]]`
- **Explanation:**
    - `nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0`
    - `nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0`
    - `nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0`

  The distinct triplets are `[-1, 0, 1]` and `[-1, -1, 2]`. Notice that the order of the output and the order of the triplets does not matter.

### Example 2

- **Input:** `nums = [0, 1, 1]`
- **Output:** `[]`
- **Explanation:** The only possible triplet does not sum up to 0.

### Example 3

- **Input:** `nums = [0, 0, 0]`
- **Output:** `[[0, 0, 0]]`
- **Explanation:** The only possible triplet sums up to 0.

## Constraints

- `3 <= nums.length <= 3000`
- `-10^5 <= nums[i] <= 10^5`
## Explanation of the `ThreeSum` Solution

The goal of this solution is to find all unique triplets in an integer array `nums` such that the sum of the triplet equals zero. The idea is to fix one number (`start`) and then use a two-pointer technique to find the other two numbers (`left`, `right`) that, together with the fixed number, sum to zero.

### Steps Involved:

1. **Sorting the Array:**
  - First, we sort the array in ascending order. Sorting helps us efficiently find pairs that sum to a specific value and skip duplicate values easily.
  - Example: An unsorted array `[4, 2, 5, 1, 3]` would be sorted to `[1, 2, 3, 4, 5]`.

2. **Initialize Result List:**
  - We initialize a list of lists to store the result triplets.

3. **Outer Loop (`start`):**
  - We fix the first number of the triplet (`nums[start]`) and iterate over the array. The loop continues until the `start` pointer is less than `nums.Length - 2`, ensuring there are at least three numbers left to form a triplet.

4. **Two-Pointer Technique:**
  - **Left Pointer:** Initialized to the element right after `start`.
  - **Right Pointer:** Initialized to the last element of the array.
  - The two pointers move towards each other to find two numbers that, when added to `nums[start]`, sum to zero.

5. **Finding the Triplet:**
  - **Expected Sum:** Calculate the sum of `nums[start] + nums[left] + nums[right]`.
  - **Adjusting Pointers:**
    - If the sum is less than zero, move the `left` pointer to the right to increase the sum.
    - If the sum is greater than zero, move the `right` pointer to the left to decrease the sum.
    - If the sum equals zero, a valid triplet is found, and we add it to the result list.

6. **Skipping Duplicates:**
  - After finding a valid triplet, move the `left` pointer forward if the next value is the same as the current `left` value, and similarly, move the `right` pointer backward if the next value is the same as the current `right` value. This ensures that no duplicate triplets are added to the result.

7. **Handling Duplicate `start`:**
  - After completing the two-pointer search for a particular `start`, move `start` to the next unique value to avoid duplicate triplets starting with the same number.

8. **Final Result:**
  - The method returns a list of all unique triplets that sum to zero.

### Example Output:
If we run the function with an input array `[-1, 0, 1, 2, -1, -4]`, the output will be:

```
[[-1, -1, 2], [-1, 0, 1]]
```
