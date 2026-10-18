public class Solution {
    public int ClimbStairs(int n) {   
        if(n<=2)
            return n;

        return ClimbStairs(n-2) + ClimbStairs(n-1);
    }
}
