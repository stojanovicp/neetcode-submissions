public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        var res = new List<List<int>>();
        int n = nums.Length;

        Backtrack(0, new List<int>(), n, res, nums);

        return res;
    }

    private void Backtrack(int index, List<int> currentSubset, int n, List<List<int>> res, int[] nums)
    {
        if(index == n)
        {
            res.Add(new List<int>(currentSubset));
            return;
        }

        Backtrack(index+1, currentSubset, n, res, nums);

        currentSubset.Add(nums[index]);

        Backtrack(index+1, currentSubset, n, res, nums);

        currentSubset.RemoveAt(currentSubset.Count - 1);
    }
}
