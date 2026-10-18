public class Solution {
    public int UniquePaths(int m, int n) {
        return memoization(0,0,m,n,new int[m, n]);
    }
    private int memoization(int r, int c, int rows, int cols, int[,] cache)
    {
        if(r == rows || c == cols)
            return 0;
        if(cache[r, c] > 0)
            return cache[r, c];
        if(r == rows-1 && c == cols-1)
            return 1;
        
        cache[r, c] = memoization(r+1,c,rows,cols,cache) + memoization(r,c+1,rows,cols,cache);
        return cache[r, c];
    }
}
