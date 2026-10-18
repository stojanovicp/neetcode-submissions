public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var set = new HashSet<int>();
        int L = 0;

        for(int R = 0; R < nums.Length; R++)
        {
            if(R-L > k)
            {
                set.Remove(nums[L]);
                L++;
            }

            if(!set.Add(nums[R]))
                return true;
        }
        return false;
    }
}