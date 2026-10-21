public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int top = 0;
        int bottom = matrix.Length - 1;

        while(top <= bottom)
        {
            int middleRow = top + (bottom - top) / 2;

            if(matrix[middleRow][^1] < target)
            {
                top = middleRow + 1;
            }
            else if(matrix[middleRow][0] > target)
            {
                bottom = middleRow - 1;
            }
            else
            {
                return SearchRow(matrix, middleRow, target);
            }
        }
        return false;
    }
    private bool SearchRow(int[][] matrix, int row, int target)
    {
        int left = 0;
        int right = matrix[row].Length - 1;

        while(left <= right)
        {
            int middleCol = left + (right - left) / 2;
            
            if(matrix[row][middleCol] > target)
            {
                right = middleCol - 1;
            }
            else if(matrix[row][middleCol] < target)
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
