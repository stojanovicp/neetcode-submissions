public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSum = nums[0];
        int currSum = 0;

        foreach(int n in nums)
        {
            currSum = Math.Max(currSum,0);
            currSum += n;
            maxSum = Math.Max(currSum, maxSum);
        }

        return maxSum;
    }
}
