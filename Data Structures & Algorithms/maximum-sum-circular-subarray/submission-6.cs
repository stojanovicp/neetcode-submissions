public class Solution {
    public int MaxSubarraySumCircular(int[] nums) {
        int maxSum = nums[0];
        int minSum = nums[0];
        int totalSum = 0;
        int currMax = 0;
        int currMin = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            totalSum += nums[i];

            currMax = Math.Max(nums[i], currMax + nums[i]);
            currMin = Math.Min(nums[i], currMin + nums[i]);

            maxSum = Math.Max(currMax, maxSum);
            minSum = Math.Min(currMin, minSum);
        }

        return maxSum < 0 ? maxSum : Math.Max(maxSum, totalSum - minSum);
    }
}