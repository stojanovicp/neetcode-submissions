public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        
        return memoization(text1, text2, 0, 0, new Dictionary<(int, int), int>());
    }
    private int memoization(string text1, string text2, int i, int j, Dictionary<(int, int), int> cache)
    {
        if(i == text1.Length || j == text2.Length)
            return 0;
        if(cache.ContainsKey((i, j)))
            return cache[(i, j)];
        int count = 0;
        if(text1[i] == text2[j])
        {
            count = 1 + memoization(text1, text2, i + 1, j + 1, cache);
        }
        else
        {
            count = Math.Max(memoization(text1, text2, i + 1, j, cache), memoization(text1, text2, i, j + 1, cache));
        }
        cache[(i, j)] = count;
        return count;
    }
}
