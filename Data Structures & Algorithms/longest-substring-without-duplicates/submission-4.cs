public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> lastSeen = new();
        int left = 0;
        int maxLength = 0;

        for(int right = 0; right < s.Length; right++)
        {
            if(lastSeen.TryGetValue(s[right], out int previousIndex) && previousIndex >= left)
            {
                left = previousIndex + 1;
            }

            lastSeen[s[right]] = right;
            maxLength = Math.Max(right - left + 1, maxLength);
        }

        return maxLength;
    }
}
