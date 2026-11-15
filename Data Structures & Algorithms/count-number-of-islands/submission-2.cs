public class Solution {
    public int NumIslands(char[][] grid) {
        int islandCount = 0;
        HashSet<(int row, int col)> visited = new();

        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[0].Length ; j++)
            {
                if(grid[i][j] == '1' && !visited.Contains((i,j)))
                {
                    DeleteIsland(grid, i, j, visited);
                    islandCount++;
                }
            }
        }

        return islandCount;
    }
    private void DeleteIsland(char[][] grid, int row, int col, HashSet<(int, int)> visited)
    {
        if(row < 0 || col < 0 || row >= grid.Length || col >= grid[0].Length || grid[row][col] == '0' || visited.Contains((row,col)))
            return;
        
        grid[row][col] = '0';
        visited.Add((row,col));

        DeleteIsland(grid, row-1, col, visited);
        DeleteIsland(grid, row+1, col, visited);
        DeleteIsland(grid, row, col-1, visited);
        DeleteIsland(grid, row, col+1, visited);
    }
}
