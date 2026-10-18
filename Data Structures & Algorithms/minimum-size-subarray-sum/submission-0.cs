public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int L = 0, R = 0;
        int length = nums.Length + 1;
        int sum = 0;

        for(; R < nums.Length; R ++)
        {
            sum += nums[R];
            while(sum >= target)
            {
                length = Math.Min(length, R-L+1);
                sum -= nums[L];
                L++;
            }
        }

        return length == nums.Length + 1 ? 0 : length;
    }
}