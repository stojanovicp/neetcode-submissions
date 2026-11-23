public class Solution {
    public int Trap(int[] height) {
        int trappedWater = 0;
        
        int left = 0;
        int right = height.Length - 1;

        int leftMax = 0;
        int rightMax = 0;

        while(left < right)
        {
            leftMax = Math.Max(height[left], leftMax);
            rightMax = Math.Max(height[right], rightMax);

            if(leftMax < rightMax)
            {
                trappedWater += (leftMax - height[left]);
                left++;
            }
            else
            {
                trappedWater += (rightMax - height[right]);
                right--;
            }
        }


        return trappedWater;
    }
}