public class Solution {
    public int OrangesRotting(int[][] grid) {
        Queue<(int row, int col)> queue = new();
        int freshCount = 0;
        int minutesPassed = 0;

        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[0].Length; j++)
            {
                if(grid[i][j] == 2)
                    queue.Enqueue((i,j));
                else if(grid[i][j] == 1)
                    freshCount++;
            }
        }


        (int row, int col)[] directions = {(0,1),(0,-1),(1,0),(-1,0)};

        while(queue.Count > 0 && freshCount > 0)
        {
            int levelSize = queue.Count;

            for(int i = 0; i < levelSize; i++)
            {
                (int row, int col) = queue.Dequeue();

                foreach((int row,int col) direction in directions)
                {
                    int newRow = row + direction.row;
                    int newCol = col + direction.col;

                    if(CanRot(newRow, newCol, grid))
                    {
                        grid[newRow][newCol] = 2;
                        freshCount--;
                        queue.Enqueue((newRow, newCol));
                    }
                }

            }
            minutesPassed++;
        }

        return freshCount == 0 ? minutesPassed : -1;
    }
    private bool CanRot(int row, int col, int[][] grid)
    {
        return row >= 0 && row < grid.Length && col >= 0 && col < grid[0].Length && grid[row][col] == 1;
    }
}
