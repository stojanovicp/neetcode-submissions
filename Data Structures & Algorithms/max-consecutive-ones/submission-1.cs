public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int currentNumOfConsecutiveOnes = 0;
        int maxNumOfConsecutiveOnes = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 1)
            {
                currentNumOfConsecutiveOnes ++;
            }
            else
            {
                currentNumOfConsecutiveOnes = 0;
            }
            
            if(currentNumOfConsecutiveOnes > maxNumOfConsecutiveOnes)
            {
                maxNumOfConsecutiveOnes = currentNumOfConsecutiveOnes;
            }
        }
        return maxNumOfConsecutiveOnes;
    }
}