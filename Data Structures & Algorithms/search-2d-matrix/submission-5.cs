public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int top = 0;
        int bottom = matrix.Length - 1;
        int l = 0;
        int r = matrix[0].Length - 1;

        while(top <= bottom)
        {
            int mH = top + (bottom - top) / 2;
            
            if(matrix[mH][l] <= target && matrix[mH][r] >= target)
            {
                while(l <= r)
                {
                    int mW = l + (r - l) / 2;
                    
                    if(matrix[mH][mW] > target)
                    {
                        r = mW - 1;
                    }
                    else if(matrix[mH][mW] < target)
                    {
                        l = mW + 1;
                    }
                    else
                    {
                        return true;
                    }
                }
                return false;
            }
            else if(matrix[mH][0] > target)
            {
                bottom = mH - 1;
            }
            else if(matrix[mH][0] < target)
            {
                top = mH + 1;
            }
        }
        return false;
    }
}
