public class Solution {
    public int MaxArea(int[] heights) {
        int L = 0, R = heights.Length - 1;
        int area = 0;
        int maxArea = 0;
        while(L < R)
        {
            area = Math.Min(heights[L], heights[R]) * (R - L);
            maxArea = Math.Max(area, maxArea);
            if(heights[L] > heights[R])
                R--;
            else
                L++;
        }
        return maxArea;
    }
}
