public class Solution {
    public int MaxSubarraySumCircular(int[] nums) {
        if(nums.Length == 0)
            return -1;
        
        int curMax = 0, maxSum = nums[0];
        int curMin = 0, minSum = nums[0];
        int total = 0;

        foreach(int n in nums)
        {
            //Max
            curMax = Math.Max(curMax, 0);
            curMax += n;
            maxSum = Math.Max(maxSum, curMax);
            //Min
            curMin = Math.Min(curMin, 0);
            curMin += n;
            minSum = Math.Min(minSum, curMin);
            //Total sum
            total += n;
        }

        if(maxSum < 0)
            return maxSum;
        return Math.Max(total - minSum, maxSum);
    }
}