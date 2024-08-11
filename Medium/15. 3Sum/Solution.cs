//Explain the solution:
// The idea is to fix a number (the start number of sorted array) and then use 2 pointer technique to find the other 2 that sum of them is 0

namespace TestSolutionLeetCode;

public class Solution
{
    private IList<IList<int>> ThreeSum(int[] nums )
    {
        //First, we sort the array to ascending order, example: 4 2 5 1 3-> 1 2 3 4 5 
        Array.Sort(nums);
        //Initialize List of List typr int
        IList<IList<int>> result = new List<IList<int>>();
        // the fixed number is the first number of the literation
        int start = 0;
        while (start < nums.Length - 2)
        {
            //2 pointer at the second start and end of array
            int left = start + 1;
            int right = nums.Length - 1;
            while (left < right)
            {
                // the expected sum is the start number + the number at the left pointer + the right pointer
                int  ExpectedSum = nums[start] +nums[left] + nums[right];
                //if the sum < o it means we need to move up to the right so we increase the left ponter and check agian
                if (ExpectedSum < 0)
                {
                    left++;
                }
                //Check if it larger it means we need to move to the right
                else if (ExpectedSum > 0)
                {
                    right--;
                }
                //if we meeet the condition, thatmean we have found the triple
                else
                {
                    result.Add(new List<int> { nums[start], nums[left], nums[right] });
                    while (left < right && nums[left] == nums[left + 1]) // this step is check for the dupliatING (EX: 1 2(LEFT) 2(left+1) 3 4 6)
                    {
                        left++;
                    }
                    while (left < right && nums[right] == nums[right - 1])// SAME
                    {
                        right--;
                    }

                    left++; //move the pointer to the next index
                    right--;//move the pointer to the next index
                }
            }

            while (start < nums.Length - 2 && nums[start] == nums[start + 1]) {
                start++;
            }// check duplicate of start 
            
            start++; // after the 1st literation move start to next element in the array
        }

        return result;
    }
    public void solution(int[] nums)
    {
        var result = ThreeSum(nums);
        foreach (var triplet in result)
        {
            Console.WriteLine($"[{string.Join(", ", triplet)}]");
        }
    }
   
}