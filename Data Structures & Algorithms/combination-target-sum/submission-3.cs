public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<List<int>> result = new();

        FindCombinations(nums, target, new List<int>(), result, 0);

        return result;
    }
    private void FindCombinations(int[] nums, int remainingSum, List<int> currentCombination, List<List<int>> result, int startIndex)
    {
        if(remainingSum < 0)
            return;

        if(remainingSum == 0)
        {
            result.Add(new List<int>(currentCombination));
            return;
        }

        for(int i = startIndex; i < nums.Length; i++)
        {
            currentCombination.Add(nums[i]);
            FindCombinations(nums, remainingSum - nums[i], currentCombination, result, i);
            currentCombination.RemoveAt(currentCombination.Count - 1);
        }
    }
}
