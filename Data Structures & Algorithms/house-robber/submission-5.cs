public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return nums[0];

        int[] dp = new int[2];
        dp[0] = nums[0];
        dp[1] = Math.Max(nums[1], nums[0]);

        for(int i = 2; i < nums.Length; i++)
        {
            int temp = Math.Max(dp[0] + nums[i], dp[1]);
            dp[0] = dp[1];
            dp[1] = temp;
        }
        return dp[1];
    }
}
