public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var hashMap = new Dictionary<int,int>();
        for(int i=0; i < nums.Length; i++)
        {
            if(hashMap.ContainsKey(target - nums[i]))
            {
                return[hashMap[target-nums[i]],i];
            }
            hashMap.Add(nums[i],i);
        }
        return [0,0];
    }
}
