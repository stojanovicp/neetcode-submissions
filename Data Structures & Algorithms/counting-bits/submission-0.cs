public class Solution {
    public int[] CountBits(int n) {
        var res = new int[n+1];
        for(int i=0; i <= n; i++)
        {
            int num = i;
            while(num > 0)
            {
                if((num & 1) == 1)
                    res[i]++;
                num >>= 1;
            }
        }
        return res;
    }
}
