public class Solution {
    public int NumOfSubarrays(int[] arr, int k, int threshold) {
        
        int count = 0;
        int currentSum = 0;
        int targetSum = k*threshold;

        for(int right = 0; right < arr.Length; right++)
        {
            currentSum += arr[right];

            if(right >= k)
                currentSum -= arr[right-k];
            
            if (right >= k - 1 && currentSum >= targetSum)
                count++;
        }

        return count;
    }
}