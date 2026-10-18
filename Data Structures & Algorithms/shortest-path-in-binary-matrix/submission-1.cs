public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid) {
        int n = grid.Length;
        var q = new Queue<(int row,int col)>();
        int length = 1;
        q.Enqueue((0,0));
        while(q.Count>0)
        {
            int size = q.Count;
            for(int i = 0; i < size; i++)
            {
                (int row, int col) = q.Dequeue();
                if(row < 0 || col < 0 || row >= n || col >= n || grid[row][col] == 1)
                    continue;
                if(row == n-1 && col == n-1)
                    return length;

                grid[row][col] = 1;

                q.Enqueue((row-1,col-1));
                q.Enqueue((row+1,col-1));
                q.Enqueue((row-1,col+1));
                q.Enqueue((row+1,col+1));
                q.Enqueue((row,col-1));
                q.Enqueue((row-1,col));
                q.Enqueue((row+1,col));
                q.Enqueue((row,col+1));

            }
            length++;
        }
        return -1;
    }
}