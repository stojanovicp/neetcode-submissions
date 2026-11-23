public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0;
        int right = heights.Length - 1;
        int maxArea = 0;

        while(left < right)
        {
            int height = Math.Min(heights[left], heights[right]);

            int currentArea = height * (right - left);

            maxArea = Math.Max(currentArea, maxArea);

            if(heights[left] > heights[right])
                right--;
            else
                left++;
        }

        return maxArea;
    }
}
