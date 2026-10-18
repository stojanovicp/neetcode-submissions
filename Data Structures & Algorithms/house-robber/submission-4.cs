public class Solution {
    public int Rob(int[] nums) {
        int[] cache = new int[nums.Length];
        Array.Fill(cache, -1);
        return Solve(nums, 0, cache);
    }
    private int Solve(int[] nums, int i, int[] cache)
    {
        if(i >= nums.Length)
            return 0;
        
        if(cache[i] != -1)
            return cache[i];
        
        int take = nums[i] + Solve(nums, i+2, cache);
        int skip = Solve(nums, i+1, cache);

        cache[i] = Math.Max(take, skip);
        return cache[i];
    }
}
