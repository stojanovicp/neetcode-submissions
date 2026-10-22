public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        int left = 0;
        int right = nums.Length - 1;
        int targetIndex = nums.Length - k;

        while (left <= right)
        {
            int pivotIndex = Partition(nums, left, right);

            if (pivotIndex == targetIndex)
                return nums[pivotIndex];

            if (pivotIndex < targetIndex)
                left = pivotIndex + 1;
            else
                right = pivotIndex - 1;
        }

        return -1;
    }

    private int Partition(int[] nums, int left, int right)
    {
        int pivot = nums[right];
        int position = left;

        for (int i = left; i < right; i++)
        {
            if (nums[i] <= pivot)
            {
                (nums[position], nums[i]) = (nums[i], nums[position]);
                position++;
            }
        }

        (nums[position], nums[right]) = (nums[right], nums[position]);

        return position;
    }
}
