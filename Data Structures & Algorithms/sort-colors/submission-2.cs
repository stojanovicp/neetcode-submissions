public class Solution {
    public void SortColors(int[] nums) {
        int low = 0;
        int mid = 0;
        int high = nums.Length - 1;
        
        while(mid <= high)
        {
            switch(nums[mid])
            {
                case 0:
                    (nums[low],nums[mid]) = (nums[mid],nums[low]);
                    low++;
                    mid++;
                    break;

                case 1:
                    mid++;
                    break;

                case 2:
                    (nums[high],nums[mid]) = (nums[mid],nums[high]);
                    high--;
                    break;

                default:
                    break;
            }
        }
    }
}