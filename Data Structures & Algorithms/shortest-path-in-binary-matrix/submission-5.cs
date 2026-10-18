public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid) {
        int n = grid.Length;

        if (grid[0][0] == 1 || grid[n - 1][n - 1] == 1)
            return -1;

        var directions = new (int, int)[] {
            (-1,-1), (-1,0), (-1,1),
            (0,-1),          (0,1),
            (1,-1),  (1,0),  (1,1)
        };

        var q = new Queue<(int row,int col)>();
        q.Enqueue((0,0));
        grid[0][0] = 1;

        int length = 1;
        while(q.Count > 0)
        {
            int size = q.Count;
            for(int i = 0; i < size; i++)
            {
                (int row, int col) = q.Dequeue();

                if(row == n-1 && col == n-1)
                    return length;

                foreach (var (dr, dc) in directions) {
                    int nr = row + dr;
                    int nc = col + dc;

                    if (nr >= 0 && nc >= 0 && nr < n && nc < n && grid[nr][nc] == 0) {
                        grid[nr][nc] = 1; // mark visited
                        q.Enqueue((nr, nc));
                    }
                }
            }
            length++;
        }
        return -1;
    }
}