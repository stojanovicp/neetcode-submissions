public class Solution {
    private int[] cache;
    public int Rob(int[] nums) {
        cache = new int[nums.Length];
        Array.Fill(cache, -1);

        return Solve(nums, 0);
    }
    private int Solve(int[] nums, int i)
    {
        if(i >= nums.Length)
            return 0;
        
        if(cache[i] != -1)
            return cache[i];
        
        int take = nums[i] + Solve(nums, i+2);
        int skip = Solve(nums, i+1);

        cache[i] = Math.Max(take, skip);
        return cache[i];
    }
}
