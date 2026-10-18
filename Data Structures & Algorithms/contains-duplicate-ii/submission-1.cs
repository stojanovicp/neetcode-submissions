public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        if(nums.Length <= 1)
            return false;
            
        var set = new HashSet<int>();
        set.Add(nums[0]);
        int L = 0;
        for(int R = 1; R < nums.Length; R++)
        {
            if(R-L > k)
            {
                set.Remove(nums[L]);
                L++;
            }

            if(set.Contains(nums[R]))
                return true;
            
            set.Add(nums[R]);
        }
        return false;
    }
}