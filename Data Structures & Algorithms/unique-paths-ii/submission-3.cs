public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        int m = obstacleGrid.Length, n = obstacleGrid[0].Length;
        int[,] memo = new int[m, n];
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                memo[i, j] = -1;
        return UniquePathsDFS(obstacleGrid, 0, 0, memo);
    }
    private int UniquePathsDFS(int[][] grid, int row, int col, int[,] memo)
    {
        if(row < 0 || col < 0 || row >= grid.Length || col >= grid[0].Length || 
            grid[row][col] == 1)
        {
            return 0;
        }


        if(row == grid.Length - 1 && col == grid[0].Length - 1)
            return 1;
        if(memo[row, col] != -1)
            return memo[row, col];
            
        memo[row, col] = UniquePathsDFS(grid, row+1, col, memo) +
            UniquePathsDFS(grid, row, col+1, memo);

        return memo[row, col];
    }
}