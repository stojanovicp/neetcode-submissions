public class Solution {
    public int OrangesRotting(int[][] grid) {
        int n = grid.Length;
        int m = grid[0].Length;

        int fresh = 0;
        var q = new Queue<(int row, int col)>();

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                if(grid[i][j] == 2)
                {
                    q.Enqueue((i,j));
                }
                if(grid[i][j] == 1)
                {
                    fresh++;
                }
            }
        }

        int minutes = 0;

        var directions = new (int, int)[]
        {   (-1, 0), (0, -1), (1, 0), (0, 1)    };

        while(q.Count > 0)
        {   
            int size = q.Count;
            for(int i = 0; i < size; i++)
            {
                (int row, int col) = q.Dequeue();
                
                foreach((var rr, var cc) in directions)
                {
                    int nr = row + rr;
                    int nc = col + cc;
                    if(nr >= 0 && nc >= 0 && nr < n && nc < m && grid[nr][nc] == 1)
                    {
                        grid[nr][nc] = 2;
                        fresh--;
                        q.Enqueue((nr, nc));
                    }
                }
            }
            if(q.Count > 0)
                minutes++;
        }
        if(fresh == 0)
            return minutes;
        else
            return -1;
    }
}
