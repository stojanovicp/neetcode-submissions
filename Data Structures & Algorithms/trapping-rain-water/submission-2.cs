public class Solution {
    public int Trap(int[] height) {
        int[] prefix = new int[height.Length];
        int[] suffix = new int[height.Length];

        int curMax = height[0]; 
        for(int i = 0; i < height.Length; i ++)
        { 
            curMax = Math.Max(curMax, height[i]);
            prefix[i] = curMax;
        }
        
        curMax = height[height.Length-1]; 
        for(int i = height.Length-1; i >= 0; i --)
        {
            curMax = Math.Max(curMax, height[i]);
            suffix[i] = curMax;
        }

        int area = 0;
        for(int i = 0; i < height.Length; i ++)
        {
            area += Math.Min(prefix[i], suffix[i]) - height[i];
        }

        return area;
    }
}
