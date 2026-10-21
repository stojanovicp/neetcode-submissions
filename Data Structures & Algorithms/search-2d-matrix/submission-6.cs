public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int top = 0;
        int bottom = matrix.Length - 1;
        int left = 0;
        int right = matrix[0].Length - 1;

        while(top <= bottom)
        {
            int middleRow = top + (bottom - top) / 2;

            if(matrix[middleRow][right] < target)
            {
                top = middleRow + 1;
            }
            else if(matrix[middleRow][0] > target)
            {
                bottom = middleRow - 1;
            }
            else
            {
                while(left <= right)
                {
                    int middleCol = left + (right - left) / 2;
                    
                    if(matrix[middleRow][middleCol] > target)
                    {
                        right = middleCol - 1;
                    }
                    else if(matrix[middleRow][middleCol] < target)
                    {
                        left = middleCol + 1;
                    }
                    else
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        return false;
    }
}
