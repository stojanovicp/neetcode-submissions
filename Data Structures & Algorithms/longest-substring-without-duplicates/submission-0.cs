public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int length = 0, curLen = 0;
        HashSet<char> seen = new HashSet<char>();
        int L = 0, R = 0;

        for(; R < s.Length; R ++)
        {
            if(seen.Contains(s[R]))
            {
                R = L;
                L++;
                seen.Clear();
                curLen = 0;
            }
            else
            {
                seen.Add(s[R]);
                curLen ++;
                length = Math.Max(curLen, length);
            }
        }
        return length;
    }
}
