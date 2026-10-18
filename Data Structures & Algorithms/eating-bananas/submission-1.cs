public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int upper = -1;
        int lower = 1;

        for(int i = 0; i < piles.Length; i++)
        {
            if(upper<piles[i])
                upper = piles[i];
        }

        int k = 0, ans = upper;

        while(lower <= upper)
        {
            k = lower + (upper - lower) / 2;
            int sum = 0;
            bool slow = false;

            for(int i = 0; i < piles.Length; i++)
            {
                sum += (piles[i]/k);

                if(piles[i] % k != 0) 
                    sum ++;

                if(sum > h)
                {
                    slow = true;
                    break;
                }
            }

            if(!slow)
            {
                ans = k;
                upper = k - 1;
            }
            else
            {
                lower = k + 1;
            }
        }
        return ans;
    }
}
