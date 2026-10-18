public class Solution {
    public void SortColors(int[] nums) 
    {
        int[] colors = new int[3];

        for(int i=0; i < nums.Length; i++)
        {
            colors[nums[i]]+=1;
        }

        int a=0;

        for(int n=0; n<colors.Length; n++)
        {
            for(int j=0; j < colors[n]; j++)
            {
                nums[a] = n;
                a++;
            }
        }

    }
}