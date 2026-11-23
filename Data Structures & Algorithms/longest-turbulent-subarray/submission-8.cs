public class Solution {
    public int MaxTurbulenceSize(int[] arr) {
        int maxLength = 1;
        int currentLength = 1;
        int previousSign = 0;

        for(int i = 1; i < arr.Length; i ++)
        {
            int currentSign = Math.Sign(arr[i]- arr[i-1]);

            if(currentSign == 0)
                currentLength = 1;
            else if(currentSign != previousSign)
                currentLength ++;
            else
                currentLength = 2;

            previousSign = currentSign;
            maxLength = Math.Max(currentLength, maxLength);
        }

        return maxLength;
    }
}