public class Solution {
    public int Rob(int[] nums) {

        int previousPrevious = 0;
        int previous = 0;


        for(int i = 0; i < nums.Length; i++)
        {
            int current = Math.Max(previous, previousPrevious + nums[i]);
            previousPrevious = previous;
            previous = current;
        }

        return previous;    
    }
}