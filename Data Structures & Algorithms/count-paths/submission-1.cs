public class Solution {
    public int UniquePaths(int m, int n) {
        var lastRow = new int[n];
        Array.Fill(lastRow, 1);
        for(int i = m-2; i >= 0; i--)
        {
            var newRow = new int[n];
            newRow[n-1] = 1;
            for(int j = n-2; j >= 0; j--)
            {
                newRow[j] = lastRow[j] + newRow[j+1];
            }
            lastRow = newRow;
        }
        return lastRow[0];
    }
}
