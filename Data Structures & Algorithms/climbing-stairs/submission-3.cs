public class Solution {
    public int ClimbStairs(int n) {
        if(n < 2)
            return n;
        
        int[] dp = new int [2];
        dp[0] = 1;
        dp[1] = 2;

        int count = 3;
        
        while(count <= n)
        {
            int temp = dp[1];
            dp[1] = dp[1] + dp[0];
            dp[0] = temp;
            count ++;
        }
        return dp[1];
    }
}
