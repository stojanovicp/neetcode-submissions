public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {

        int startColor = image[sr][sc];
        if(startColor == color)
            return image;

        Queue<(int row,int col)> queue = new Queue<(int,int)>();

        queue.Enqueue((sr,sc));

        while(queue.Count > 0)
        {
            (int row, int col) = queue.Dequeue();

            if(row >= 0 && row < image.Length && col >= 0 && col < image[0].Length && image[row][col] == startColor)
            {
                image[row][col] = color;

                queue.Enqueue((row+1,col));
                queue.Enqueue((row-1,col));
                queue.Enqueue((row,col+1));
                queue.Enqueue((row,col-1));
            }
        }
        return image;
    }
}