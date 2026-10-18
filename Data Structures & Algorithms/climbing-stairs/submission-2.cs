public class Solution {
    private int[] memo;
    public int ClimbStairs(int n) {
        memo = new int[n+1];
        return Solve(n);
    }
    private int Solve(int n)
    {
        if(n<=2) return n;
        if(memo[n] != 0)
            return memo[n];
        
        memo[n] = Solve(n-1) + Solve(n-2);
        return memo[n];
    }
}
