public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<List<int>> result = new();

        Backtracking(nums, target, new List<int>(), result, 0);

        return result;
    }
    private void Backtracking(int[] nums, int target, List<int> list, List<List<int>> result, int index)
    {
        if(target < 0)
            return;

        if(target == 0)
            result.Add(new List<int>(list));

        for(int i = index; i < nums.Length; i++)
        {
            list.Add(nums[i]);
            Backtracking(nums, target - nums[i], list, result, i);
            list.RemoveAt(list.Count - 1);
        }
    }
}
