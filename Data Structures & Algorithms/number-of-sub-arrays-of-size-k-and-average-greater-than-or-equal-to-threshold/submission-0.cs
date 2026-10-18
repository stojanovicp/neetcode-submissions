public class Solution {
    public int NumOfSubarrays(int[] arr, int k, int threshold) {
        int sum = threshold * k;
        int L=0;
        int curSum = 0;
        int count = 0;

        for(int R=0; R<arr.Length; R++)
        {
            curSum += arr[R];
            
            if(R-L == k-1)
            {
                if(curSum >= sum)
                    count++;
                curSum -= arr[L];
                L++;
            }
        }

        return count;
    }
}