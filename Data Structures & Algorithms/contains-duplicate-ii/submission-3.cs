public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        HashSet<int> inWindow = new();
        int L = 0;

        for(int R = 0; R < nums.Length; R++)
        {
            if(R - L > k)
            {
                inWindow.Remove(nums[L]);
                L++;
            }

            if(inWindow.Contains(nums[R]))
                return true;
            
            inWindow.Add(nums[R]);
        }
        return false;
    }
}