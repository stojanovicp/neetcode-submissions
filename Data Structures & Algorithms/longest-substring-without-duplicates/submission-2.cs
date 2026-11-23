public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> seen = new();
        int left = 0;
        int maxLength = 0;

        for(int right = 0; right < s.Length; right++)
        {
            if(seen.ContainsKey(s[right]) && seen[s[right]] >= left)
            {
                left = seen[s[right]] + 1;
                seen[s[right]] = right;
            }

            seen[s[right]] = right;
            maxLength = Math.Max(right - left + 1, maxLength);
        }

        return maxLength;
    }
}
