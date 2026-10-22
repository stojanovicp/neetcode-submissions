public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> seen = new();

        for(int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (seen.TryGetValue(complement, out int index))
                return new int[] { index, i };

            seen.TryAdd(nums[i], i);
        }
        return new int[2];
    }
}
