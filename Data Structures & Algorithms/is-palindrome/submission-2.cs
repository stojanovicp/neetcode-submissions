public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        int L = 0, R = s.Length-1;

        while(L < R)
        {
            while(L<R && !char.IsLetterOrDigit(s[L]))
            {
                L++;
            }
            while(L<R && !char.IsLetterOrDigit(s[R]))
            {
                R--;
            }
            if(s[L] != s[R])
                return false;
            L++;
            R--;
        }
        return true;
    }
}
