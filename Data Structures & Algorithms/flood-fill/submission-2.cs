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

            if (image[row][col] != startColor)
                continue;

            image[row][col] = color;


            if(CanFill(row+1,col,image,startColor))
                queue.Enqueue((row+1,col));

            if(CanFill(row-1,col,image,startColor))
                queue.Enqueue((row-1,col));
            
            if(CanFill(row,col+1,image,startColor))
                queue.Enqueue((row,col+1));

            if(CanFill(row,col-1,image,startColor))
                queue.Enqueue((row,col-1));
        }
        return image;
    }
    private bool CanFill(int row, int col, int[][] image, int startColor)
    {
        return row >= 0 && row < image.Length && col >= 0 && col < image[0].Length && image[row][col] == startColor;
    }
}