public class Solution {
    public int MaxTurbulenceSize(int[] arr) {
        int n = arr.Length;
        if(n == 1)
            return 1;
        if(n == 2)
            return (arr[0] == arr[1]) ? 1 : 2;

        int curLen = 1, maxLen = 1;
        int last=0;
        for(int i = 1; i < n; i++)
        {
            int curr = Math.Sign(arr[i] - arr[i-1]);
            if(curr == 0)
                curLen = 1;
            else if(curr == -1*last)
                curLen ++;
            else 
                curLen = 2;
            
            last = curr;
            maxLen = Math.Max(maxLen, curLen);
        }
        return maxLen;
    }
}