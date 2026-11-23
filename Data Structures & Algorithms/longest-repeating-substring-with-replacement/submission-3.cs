public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] charCount = new int[26];
        int maxFreq = 0;
        int maxLength = 0;
        int L = 0;
        
        for(int R = 0; R < s.Length; R++)
        {
            charCount[s[R] - 'A']++;
            maxFreq = Math.Max(maxFreq, charCount[s[R]-'A']);

            while((R - L + 1) - maxFreq > k)
            {
                charCount[s[L] - 'A']--;
                L++;
            }
            maxLength = Math.Max(maxLength, R - L + 1);
        }
        return maxLength;
    }
}
