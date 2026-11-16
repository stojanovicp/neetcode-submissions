public class Solution {
    public int UniquePaths(int m, int n) {
        int[] rowDP = new int[n];

        rowDP[n-1] = 1;

        for(int row = m-1; row >= 0; row--)
        {
            for(int col = n-2; col >= 0; col--)
            {
                rowDP[col] += rowDP[col+1];
            }
        }

        return rowDP[0];
    }
}
