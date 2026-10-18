public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int max = 0;
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[0].Length; j++)
            {
                if(grid[i][j] == 1)
                {
                    int size = 0;
                    DelIsland(grid, i, j, ref size);
                    max = Math.Max(max, size);
                }
            }
        }
        return max;
    }
    private void DelIsland(int[][] grid, int r, int c, ref int size)
    {
        if(c < 0 || r < 0 || r == grid.Length || c == grid[r].Length || grid[r][c] == 0)
            return;
        if(grid[r][c] == 1)
            size ++;
        
        grid[r][c] = 0;

        DelIsland(grid, r, c-1, ref size);
        DelIsland(grid, r-1, c, ref size);
        DelIsland(grid, r, c+1, ref size);
        DelIsland(grid, r+1, c, ref size);

        return;
    }
}
