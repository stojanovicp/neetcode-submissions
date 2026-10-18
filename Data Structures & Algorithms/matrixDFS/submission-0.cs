public class Solution {
    public int CountPaths(int[][] grid) {
        return BFS(grid, 0, 0);
    }
    public int BFS(int[][] grid, int r, int c)
    {
        if(c < 0 || r < 0 || r == grid.Length || c == grid[r].Length || grid[r][c] == 1)
            return 0;
        if(r == grid.Length - 1 && c == grid[r].Length - 1)
            return 1;

        grid[r][c] = 1;
        int count = 0;
        
        count += BFS(grid, r, c-1);
        count += BFS(grid, r-1, c);
        count += BFS(grid, r, c+1);
        count += BFS(grid, r+1, c);

        grid[r][c] = 0;
        return count;
    }
}
