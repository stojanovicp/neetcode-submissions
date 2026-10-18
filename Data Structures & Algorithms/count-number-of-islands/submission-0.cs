public class Solution {
    public int NumIslands(char[][] grid) {
        int counter = 0;
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[0].Length; j++)
            {
                if(grid[i][j] == '1')
                {
                    counter ++;
                    DelIsland(grid, i, j);
                }
            }
        }
        return counter;
    }
    private void DelIsland(char[][] grid, int r, int c)
    {
        if(c < 0 || r < 0 || r == grid.Length || c == grid[r].Length || grid[r][c] == '0')
            return;
        
        grid[r][c] = '0';

        DelIsland(grid, r, c-1);
        DelIsland(grid, r-1, c);
        DelIsland(grid, r, c+1);
        DelIsland(grid, r+1, c);

        return;        
    }
}
