/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        int l = 1;
        int r = n;

        while(l<=r)
        {
            int m = l+(r-l)/2;
            int a = guess(m);
            switch(a)
            {
                case -1: 
                    r = m - 1;
                    break;
                case 1: 
                    l = m + 1;
                    break;
                case 0: 
                    return m;
                    break;   
            }
        }
        return -1;
    }
}