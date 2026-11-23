public class Solution {
    public int MaxTurbulenceSize(int[] arr) {
        int maxLen = 1;
        int currLen = 1;
        int last = 0;

        for(int i = 1; i < arr.Length; i ++)
        {
            int curr = Math.Sign(arr[i]- arr[i-1]);

            if(curr == 0)
                currLen = 1;
            else if(curr != last)
                currLen ++;
            else
                currLen = 2;

            last = curr;
            maxLen = Math.Max(currLen, maxLen);
        }

        return maxLen;
    }
}