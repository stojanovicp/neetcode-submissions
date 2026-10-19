public class Solution {
    //BruteForce:
    // public int ClimbStairs(int n) {     
    //     if(n <= 2)
    //         return n;
        
    //     return ClimbStairs(n-1) + ClimbStairs(n-2);
    // }
    //Memoization:
    // public int ClimbStairs(int n) {     
    //     return ClimbStairsMemo(n, new Dictionary<int,int>());
    // }
    // public int ClimbStairsMemo(int n, Dictionary<int,int> cache)
    // {
    //     if(n <= 2)
    //         return n;
    //     if(cache.ContainsKey(n))
    //         return cache[n];
    //     int result = ClimbStairsMemo(n-1, cache) + ClimbStairsMemo(n-2, cache);
    //     cache[n] = result;
    //     return result;
    // }
    //DP:
    public int ClimbStairs(int n) {     
        if(n <= 2)
            return n;
        
        int twoStepBack = 1;
        int oneStepBack = 2;

        for(int i=3; i <= n; i++)
        {
            int currentWays = oneStepBack + twoStepBack;
            
            twoStepBack = oneStepBack;
            oneStepBack = currentWays;
        }
        return oneStepBack;
    }
}
