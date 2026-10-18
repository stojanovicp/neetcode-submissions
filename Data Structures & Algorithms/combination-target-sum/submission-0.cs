public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        var res = new List<List<int>>();
        Backtracking(nums, 0, target, res, new List<int>());

        return res;
    }
    private void Backtracking(int[] nums, int i, int target, List<List<int>> res, List<int> current)
    {
        if (target == 0)
        {
            res.Add(new List<int>(current));
            return;
        }

        if (i == nums.Length || target < 0)
            return;

        current.Add(nums[i]);
        Backtracking(nums, i, target-nums[i], res,current);
        
        current.RemoveAt(current.Count -1);
        Backtracking(nums, i+1, target, res, current);
    }
}
