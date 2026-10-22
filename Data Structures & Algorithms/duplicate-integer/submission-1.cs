public class Solution {
    public bool hasDuplicate(int[] nums) {
        var hash = new HashSet<int>();
        foreach(int n in nums)
        {
            if(hash.Contains(n))
                return true;
            hash.Add(n);
        }
        return false;
    }
}