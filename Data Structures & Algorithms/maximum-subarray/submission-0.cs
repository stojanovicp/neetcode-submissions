public class Solution {
    public int MaxSubArray(int[] nums) {
        if(nums.Length == 0)
            return -1;
        
        int curSum = 0;
        int maxSum = nums[0];

        for(int i=0; i < nums.Length; i++)
        {
            curSum = Math.Max(curSum, 0);
            curSum += nums[i];
            maxSum = Math.Max(maxSum, curSum);
        }
        return maxSum;
    }
}
