public class Solution {
    public int UniquePaths(int m, int n) {
        int[,] memo = new int[m, n];

        
        return CountPaths(m,n,0,0,memo);
    }
    private int CountPaths(int m, int n, int i, int j, int[,] memo)
    {
        if(i >= m || j >= n)
            return 0;
        if(i == m-1 && j == n-1)
            return 1;
        if(memo[i,j] != 0)
        {
            return memo[i,j];
        }

        memo[i,j] = CountPaths(m,n,i+1,j,memo) + CountPaths(m,n,i,j+1,memo); 
        return memo[i,j];
    }
}
