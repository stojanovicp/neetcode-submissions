public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        int lr = 0, rr = rows-1;
        int lc = 0, rc = cols-1;
        int mr = 0, mc=0;

        while(lr <= rr)
        {
            mr = (lr+rr)/2;

            if (target >= matrix[mr][0] && target <= matrix[mr][cols-1]) {
                // Target mora biti u ovom redu
                break;
            }

            if(matrix[mr][0] > target)
                rr = mr - 1;
            
            if(matrix[mr][0] < target)
                lr = mr + 1;
        
        }

        while(lc <= rc)
        {
            mc = (lc+rc)/2;
            if(matrix[mr][mc] == target)
                return true;

            if(matrix[mr][mc] > target)
                rc = mc - 1;
            
            if(matrix[mr][mc] < target)
                lc = mc + 1;
        }

        return false;
    }
}
