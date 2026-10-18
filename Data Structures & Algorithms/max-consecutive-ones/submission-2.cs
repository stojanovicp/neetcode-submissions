public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int maxNumOfConsecutiveOnes = 0;
        int curNumOfConsecutiveOnes = 0;
        foreach(int num in nums)
        {
            if(num == 1)
            {
                curNumOfConsecutiveOnes ++;
                if(curNumOfConsecutiveOnes > maxNumOfConsecutiveOnes)
                {
                    maxNumOfConsecutiveOnes = curNumOfConsecutiveOnes;
                }
            }
            else
            {
                curNumOfConsecutiveOnes = 0;
            }
        }
        return maxNumOfConsecutiveOnes;
    }
}