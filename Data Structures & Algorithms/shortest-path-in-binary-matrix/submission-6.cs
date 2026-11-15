public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid) {
        int n = grid.Length;

        if(grid[0][0] != 0 || grid[n-1][n-1] != 0)
            return -1;

        Queue<(int row, int col)> queue = new();
        HashSet<(int row, int col)> visited = new();
        
        queue.Enqueue((0, 0));
        visited.Add((0, 0));
        int distance = 1;

        (int,int)[] directions = {
            (0,1), (0,-1), (1,0), (-1,0),
            (1,1), (-1,1), (1,-1), (-1,-1)
        };

        while(queue.Count > 0)
        {
            int levelSize = queue.Count;

            for(int i = 0; i < levelSize; i++)
            {
                (int row, int col) = queue.Dequeue();


                if(row == n-1 && col == n-1)
                    return distance;

                foreach((int row,int col) direction in directions)
                {
                    int newRow = row + direction.row;
                    int newCol = col + direction.col;

                    if(CanGo(newRow, newCol, grid, visited))
                    {
                        visited.Add((newRow, newCol));
                        queue.Enqueue((newRow, newCol));
                    }
                }
            }
            distance++;
        }

        return -1;
    }

    private bool CanGo(int row, int col, int[][] grid, HashSet<(int row, int col)> visited)
    {
        return row >= 0 && row < grid.Length && col >= 0 && col < grid[0].Length 
        && grid[row][col] == 0 && !visited.Contains((row,col));
    }
}