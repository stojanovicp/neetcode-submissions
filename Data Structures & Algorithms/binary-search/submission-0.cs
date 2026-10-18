public class Solution {
    public int Search(int[] nums, int target) {
        int L = 0;
        int R = nums.Length - 1;
        while(L<=R)
        {
            int M = ((L+R)/2);

            if(target == nums[M]) 
                return M;
            
            if(target > nums[M])
                L=M+1;
            
            if(target < nums[M])
                R=M-1;
        }
        return -1;
    }
}
