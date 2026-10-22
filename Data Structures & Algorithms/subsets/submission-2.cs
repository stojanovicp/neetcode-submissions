public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> result = new();

        Backtracking(nums, 0, new List<int>(), result);

        return result;
    }

    private void Backtracking(int[] nums, int index, List<int> list, List<List<int>> result)
    {
        result.Add(new List<int>(list));
        for(int i = index; i < nums.Length; i++)
        {
            list.Add(nums[i]);
            Backtracking(nums,i+1,list,result);
            list.RemoveAt(list.Count - 1);
        }
    }
}
